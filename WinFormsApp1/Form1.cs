using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using QRCoder;
using Image = iText.Layout.Element.Image;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void Button1_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
        openFileDialog.Title = "Select a PDF File";

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string inputFile = openFileDialog.FileName;
            string outputFile = Path.Combine(Path.GetDirectoryName(inputFile), "output.pdf");
            string text = textBox1.Text;

            AddTextToPDF(inputFile, outputFile, text);

            MessageBox.Show("Text added to every page!");
        }
    }

    public void AddTextToPDF(string inputFile, string outputFile, string text)
    {
        PdfReader reader = new PdfReader(inputFile);
        PdfWriter writer = new PdfWriter(outputFile);
        PdfDocument pdfDoc = new PdfDocument(reader, writer);
        Document document = new Document(pdfDoc);
        int pageCount = pdfDoc.GetNumberOfPages();
        PageSize pageSize = pdfDoc.GetDefaultPageSize();
        PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
        float fontSize = 12;
        int qrCodeWidth = 50;
        int qrCodeHeight = 50;
        int qrCodeMargin = 10;

        for (int i = 1; i <= pageCount; i++)
        {
            PdfPage page = pdfDoc.GetPage(i);
            PdfCanvas canvas = new PdfCanvas(page);
            float textWidth = font.GetWidth(text, fontSize);

            // Add text to page
            canvas.BeginText();
            canvas.SetFontAndSize(font, fontSize);
            canvas.MoveText(pageSize.GetLeft() + 50, pageSize.GetTop() - 30);
            canvas.ShowText(text);
            canvas.EndText();

            // Add QR code to page
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeBitmap = qrCode.GetGraphic(qrCodeWidth, Color.Black, Color.White);
            byte[] qrCodeByteArray = ImageToByteArray(qrCodeBitmap, ImageFormat.Png);
            Image qrCodeImage = new Image(ImageDataFactory.Create(qrCodeByteArray))
                .SetFixedPosition(pageSize.GetLeft() + pageSize.GetWidth() - qrCodeMargin - qrCodeWidth, pageSize.GetBottom() + qrCodeMargin)
                .SetHeight(qrCodeHeight);

            document.Add(qrCodeImage);
        }

        document.Close();
    }

    private byte[] ImageToByteArray(System.Drawing.Image image, ImageFormat format)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            image.Save(ms, format);
            return ms.ToArray();
        }
    }
}
