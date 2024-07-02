using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;

namespace QR_Generator
{
    public partial class Form1 : Form
    {
        private Bitmap qrCodeBitmap;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {

            // Get the text to encode from the textbox
            string text = txtInput.Text.Trim();

            if (text.Length > 0)
            {
                // Generate QR Code using ZXing library
                BarcodeWriter writer = new BarcodeWriter();
                writer.Format = BarcodeFormat.QR_CODE;
                writer.Options = new ZXing.Common.EncodingOptions
                {
                    Width = 300, 
                    Height = 300, 
                    Margin = 0 
                };

                qrCodeBitmap = writer.Write(text);
                
                QRImage.Image = qrCodeBitmap;
                CenterPictureBoxImage(QRImage);
            }
            else
            {
                MessageBox.Show("Please enter some text to generate QR Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportQR_Click(object sender, EventArgs e)
        {
            if (qrCodeBitmap != null)
            {
                // Save QR code bitmap to a file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Save QR Code Image";
                saveFileDialog.ShowDialog();

                if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        qrCodeBitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                    }

                    MessageBox.Show("QR Code saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please generate a QR Code first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CenterPictureBoxImage(PictureBox pb)
        {
            if (pb.Image != null)
            {
                pb.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }
    }
}
