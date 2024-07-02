namespace QR_Generator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.QRImage = new System.Windows.Forms.PictureBox();
            this.btnExportQR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QR_Generator.Properties.Resources.ip14_3;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(906, 519);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.Color.Silver;
            this.btn_generate.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.Location = new System.Drawing.Point(102, 455);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(123, 36);
            this.btn_generate.TabIndex = 1;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = false;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.Location = new System.Drawing.Point(12, 386);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(439, 63);
            this.txtInput.TabIndex = 2;
            // 
            // QRImage
            // 
            this.QRImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QRImage.Location = new System.Drawing.Point(12, 31);
            this.QRImage.Name = "QRImage";
            this.QRImage.Size = new System.Drawing.Size(439, 349);
            this.QRImage.TabIndex = 3;
            this.QRImage.TabStop = false;
            // 
            // btnExportQR
            // 
            this.btnExportQR.BackColor = System.Drawing.Color.Silver;
            this.btnExportQR.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportQR.Location = new System.Drawing.Point(231, 455);
            this.btnExportQR.Name = "btnExportQR";
            this.btnExportQR.Size = new System.Drawing.Size(123, 36);
            this.btnExportQR.TabIndex = 4;
            this.btnExportQR.Text = "Export";
            this.btnExportQR.UseVisualStyleBackColor = false;
            this.btnExportQR.Click += new System.EventHandler(this.btnExportQR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 512);
            this.Controls.Add(this.btnExportQR);
            this.Controls.Add(this.QRImage);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QRImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.PictureBox QRImage;
        private System.Windows.Forms.Button btnExportQR;
    }
}

