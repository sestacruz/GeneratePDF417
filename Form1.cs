using Pdf417EncoderLibrary;

namespace GeneratePDF417
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Pdf417Encoder Encoder = new Pdf417Encoder();
            Encoder.DefaultDataColumns = 4;
            Encoder.Encode(txtString.Text);
            Encoder.SaveBarcodeToPngFile(".\\Temp_Barcode.png");
            byte[] barCode = File.ReadAllBytes(".\\Temp_Barcode.png");
            picBarCode.Image = ByteToImage(barCode);
            File.Delete(".\\Temp_Barcode.png");
        }

        private static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}