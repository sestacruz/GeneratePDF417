namespace GeneratePDF417
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtString = new TextBox();
            btnConvert = new Button();
            picBarCode = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBarCode).BeginInit();
            SuspendLayout();
            // 
            // txtString
            // 
            txtString.Location = new Point(12, 12);
            txtString.Name = "txtString";
            txtString.Size = new Size(181, 23);
            txtString.TabIndex = 0;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(199, 12);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(114, 23);
            btnConvert.TabIndex = 1;
            btnConvert.Text = "Convertir";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // picBarCode
            // 
            picBarCode.Location = new Point(12, 41);
            picBarCode.Name = "picBarCode";
            picBarCode.Size = new Size(301, 113);
            picBarCode.TabIndex = 2;
            picBarCode.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 167);
            Controls.Add(picBarCode);
            Controls.Add(btnConvert);
            Controls.Add(txtString);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBarCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtString;
        private Button btnConvert;
        private PictureBox picBarCode;
    }
}