using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercadinho
{
    public static class ProdutosRelatorio
    {
        private static string _subTitulo = "";

        public static string GerarRelatorio(string path, List<Produtos> listaProdutos, int setor = 0)
        {
            if(setor > 0)
            {
                _subTitulo = listaProdutos[0].Setor.Descricao;
            }

            try
            {
                using (PdfWriter wPdf = new PdfWriter(path, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
                {
                    var pdfDocument = new PdfDocument(wPdf);
                    var document = new Document(pdfDocument, PageSize.A4);

                    document.SetMargins(85f, 42.50f, 85f, 42.50f);

                    //Define as colunas da tabela(grande)
                    float[] columnWidths = { 8, 40, 5, 15, 8, 24 };
                    Table tabela = new Table(UnitValue.CreatePercentArray(columnWidths)).UseAllAvailableWidth();

                    GerarTituloTabela(tabela, _subTitulo);
                    GerarCabecalhoTabela(tabela);
                    GerarRodapeTabela(tabela);

                    //adicionar tabela (grade) no documento pdf
                    document.Add(tabela);

                    document.Close();
                    pdfDocument.Close();

                    return "ok";
                }
            }
            catch (Exception ex) 
            {
                return ex.Message;
            }


        }

        static void GerarTituloTabela(Table tabela, string subTitulo)
        {
            //Titulo principal do cabeçalho da tabela
            var fonte = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            tabela.AddHeaderCell(new Cell(1, 6)
                .Add(new Paragraph("Tabela de preço de produtos")
                .SetFont(fonte)
                .SetFontSize(18)
                .SetPadding(10)
                .SetFontColor(ColorConstants.RED)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)));

            //Titulo secundario do cabeçalho da tabela
            var fonte2 = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            if(subTitulo != "") 
            {
                tabela.AddHeaderCell(new Cell(1, 6)
                    .Add(new Paragraph("Setor: " + subTitulo)
                    .SetHeight(18)
                    .SetFont(fonte2)
                    .SetFontSize(12)
                    .SetPaddingTop(5)
                    .SetTextAlignment(TextAlignment.CENTER)));
            }
        }

        static void GerarCabecalhoTabela(Table tabela)
        {
            //Cabeçalho com os titulos das colunas da tabela(grade)
            tabela.AddHeaderCell(new Cell()
                .SetTextAlignment(TextAlignment.CENTER)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .Add(new Paragraph("Código")));

            tabela.AddHeaderCell(new Cell()
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetPaddingLeft(5)
                .Add(new Paragraph("Descrição do produto")));

            tabela.AddHeaderCell(new Cell()
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("UN")));

            tabela.AddHeaderCell(new Cell()
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetPaddingRight(10)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .Add(new Paragraph("Valor")));

            tabela.AddHeaderCell(new Cell()
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Set.")));

            tabela.AddHeaderCell(new Cell()
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetPaddingLeft(5)
                .Add(new Paragraph("Descrição do Setor")));


        }

        static void GerarRodapeTabela(Table tabela)
        {
            //Rodape da tabela
            var fonte = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            var cellFooter = new Cell(1, 6).Add(new Paragraph("Observação: Preços sujeitos a reajuste sem aviso prévio"))
                .SetFont(fonte)
                .SetFontSize(13)
                .SetFontColor(ColorConstants.BLACK)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetPaddingLeft(10)
                .SetPaddingTop(10)
                .SetBorder(Border.NO_BORDER)
                .SetBorderTop(new SolidBorder(1));

            tabela.AddFooterCell(cellFooter);

        }
    }
}
