using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplTruckMotorsDiesel.Impressao
{
    class Imprimir
    {
        public static void ImprimirRelacao(string modeloVeiculo, 
            string motor, 
            string pistao, 
            string aneis, 
            string bombaAgua, 
            string bombaOleo,
            string bronzinaMancal,
            string bronzinaBiela,
            string junta,
            string kitMotor,
            string outra)
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(20, 20, 20, 80);
            doc.AddCreationDate();
            string caminho = @"C:\BDs\" + "relatorio.pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            Paragraph titulo = new Paragraph();
            titulo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 20);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Add("Motor: " + motor + " Veiculo: " + modeloVeiculo + "\n\n");
            doc.Add(titulo);

            PdfPTable table = new PdfPTable(9);
            Font fontSize12Bold = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 12, Font.BOLD);
            Font fontSize10Bold = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 10, Font.BOLD);

            table.AddCell(new PdfPCell(new Phrase("Pistao", fontSize12Bold)));
            table.AddCell(new PdfPCell(new Phrase("Anéis", fontSize12Bold)));
            table.AddCell(new PdfPCell(new Phrase("B.Agua", fontSize12Bold)));
            table.AddCell(new PdfPCell(new Phrase("B.Oleo", fontSize12Bold)));
            table.AddCell(new PdfPCell(new Phrase("B.Mancal", fontSize10Bold)));
            table.AddCell(new PdfPCell(new Phrase("B.Biela", fontSize12Bold)));
            table.AddCell(new PdfPCell(new Phrase("Junta", fontSize12Bold)));
            table.AddCell(new PdfPCell(new Phrase("KIT", fontSize12Bold)));
            table.AddCell(new PdfPCell(new Phrase("Outro", fontSize12Bold)));

            table.AddCell(pistao);
            table.AddCell(aneis);
            table.AddCell(bombaAgua);
            table.AddCell(bombaOleo);
            table.AddCell(bronzinaMancal);
            table.AddCell(bronzinaBiela);
            table.AddCell(junta);
            table.AddCell(kitMotor);
            table.AddCell(outra);

            for (int i = 1; i <= 9; i++)
            {
                table.AddCell(" ");
                table.AddCell(" ");
                table.AddCell(" ");
                table.AddCell(" ");
                table.AddCell(" ");
                table.AddCell(" ");
                table.AddCell(" ");
                table.AddCell(" ");
                table.AddCell(" ");
            }

            doc.Add(table);

            doc.Close();

            //Abre o PDF após criar
            System.Diagnostics.Process.Start(caminho);
        }
    }
}
