using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
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
                    Table tabela = new Table(UnitValue.CreatePercentArray(columnWidths)).UseAllAvaiableWidth();

                    GerarTituloRelatorio(tabela, _subTitulo);

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
    }
}
