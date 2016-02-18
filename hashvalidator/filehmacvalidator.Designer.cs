namespace hashvalidator
{
    partial class frmFilehmacvalidator
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnValidateFileHmac = new System.Windows.Forms.Button();
            this.txtHmacValidationResult = new System.Windows.Forms.TextBox();
            this.lblSelectedFileValue = new System.Windows.Forms.Label();
            this.lblSelectedFileBaner = new System.Windows.Forms.Label();
            this.btnBrowseFileToValidateHmac = new System.Windows.Forms.Button();
            this.openFileToHmac = new System.Windows.Forms.OpenFileDialog();
            this.cmbHmacAlgo = new System.Windows.Forms.ComboBox();
            this.lblHmacAlgo = new System.Windows.Forms.Label();
            this.txtFileToValidateHmac = new System.Windows.Forms.TextBox();
            this.lblSelectHmacFile = new System.Windows.Forms.Label();
            this.lblOriginalHMAC = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtHmacKey = new System.Windows.Forms.TextBox();
            this.lblHmacKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidateFileHmac
            // 
            this.btnValidateFileHmac.Location = new System.Drawing.Point(143, 289);
            this.btnValidateFileHmac.Name = "btnValidateFileHmac";
            this.btnValidateFileHmac.Size = new System.Drawing.Size(75, 93);
            this.btnValidateFileHmac.TabIndex = 27;
            this.btnValidateFileHmac.Text = "Validate File";
            this.btnValidateFileHmac.UseVisualStyleBackColor = true;
            this.btnValidateFileHmac.Click += new System.EventHandler(this.btnValidateFileHmac_Click);
            // 
            // txtHmacValidationResult
            // 
            this.txtHmacValidationResult.Location = new System.Drawing.Point(235, 291);
            this.txtHmacValidationResult.Multiline = true;
            this.txtHmacValidationResult.Name = "txtHmacValidationResult";
            this.txtHmacValidationResult.Size = new System.Drawing.Size(413, 91);
            this.txtHmacValidationResult.TabIndex = 26;
            // 
            // lblSelectedFileValue
            // 
            this.lblSelectedFileValue.AutoSize = true;
            this.lblSelectedFileValue.Location = new System.Drawing.Point(98, 118);
            this.lblSelectedFileValue.Name = "lblSelectedFileValue";
            this.lblSelectedFileValue.Size = new System.Drawing.Size(83, 13);
            this.lblSelectedFileValue.TabIndex = 20;
            this.lblSelectedFileValue.Text = "No file selected!";
            // 
            // lblSelectedFileBaner
            // 
            this.lblSelectedFileBaner.AutoSize = true;
            this.lblSelectedFileBaner.Location = new System.Drawing.Point(12, 118);
            this.lblSelectedFileBaner.Name = "lblSelectedFileBaner";
            this.lblSelectedFileBaner.Size = new System.Drawing.Size(68, 13);
            this.lblSelectedFileBaner.TabIndex = 19;
            this.lblSelectedFileBaner.Text = "Selected file:";
            // 
            // btnBrowseFileToValidateHmac
            // 
            this.btnBrowseFileToValidateHmac.Location = new System.Drawing.Point(613, 80);
            this.btnBrowseFileToValidateHmac.Name = "btnBrowseFileToValidateHmac";
            this.btnBrowseFileToValidateHmac.Size = new System.Drawing.Size(34, 23);
            this.btnBrowseFileToValidateHmac.TabIndex = 18;
            this.btnBrowseFileToValidateHmac.Text = "...";
            this.btnBrowseFileToValidateHmac.UseVisualStyleBackColor = true;
            this.btnBrowseFileToValidateHmac.Click += new System.EventHandler(this.btnBrowseFileToValidateHmac_Click);
            // 
            // openFileToHmac
            // 
            this.openFileToHmac.FileName = "openFileDialog1";
            // 
            // cmbHmacAlgo
            // 
            this.cmbHmacAlgo.FormattingEnabled = true;
            this.cmbHmacAlgo.Items.AddRange(new object[] {
            "HMACMD5",
            "HMACSHA1",
            "HMACSHA256",
            "HMACSHA384",
            "HMACSHA512",
            "HMACRIPEMD160"});
            this.cmbHmacAlgo.Location = new System.Drawing.Point(143, 16);
            this.cmbHmacAlgo.Name = "cmbHmacAlgo";
            this.cmbHmacAlgo.Size = new System.Drawing.Size(121, 21);
            this.cmbHmacAlgo.TabIndex = 24;
            this.cmbHmacAlgo.Text = "--Select--";
            // 
            // lblHmacAlgo
            // 
            this.lblHmacAlgo.AutoSize = true;
            this.lblHmacAlgo.ForeColor = System.Drawing.Color.Red;
            this.lblHmacAlgo.Location = new System.Drawing.Point(12, 19);
            this.lblHmacAlgo.Name = "lblHmacAlgo";
            this.lblHmacAlgo.Size = new System.Drawing.Size(125, 13);
            this.lblHmacAlgo.TabIndex = 23;
            this.lblHmacAlgo.Text = "Selecte HMAC algorithm:";
            // 
            // txtFileToValidateHmac
            // 
            this.txtFileToValidateHmac.Location = new System.Drawing.Point(15, 80);
            this.txtFileToValidateHmac.Name = "txtFileToValidateHmac";
            this.txtFileToValidateHmac.Size = new System.Drawing.Size(592, 20);
            this.txtFileToValidateHmac.TabIndex = 17;
            // 
            // lblSelectHmacFile
            // 
            this.lblSelectHmacFile.AutoSize = true;
            this.lblSelectHmacFile.ForeColor = System.Drawing.Color.Red;
            this.lblSelectHmacFile.Location = new System.Drawing.Point(12, 53);
            this.lblSelectHmacFile.Name = "lblSelectHmacFile";
            this.lblSelectHmacFile.Size = new System.Drawing.Size(274, 13);
            this.lblSelectHmacFile.TabIndex = 16;
            this.lblSelectHmacFile.Text = "Select a file to calculate the HMAC or paste the file path:";
            // 
            // lblOriginalHMAC
            // 
            this.lblOriginalHMAC.AutoSize = true;
            this.lblOriginalHMAC.ForeColor = System.Drawing.Color.Red;
            this.lblOriginalHMAC.Location = new System.Drawing.Point(12, 159);
            this.lblOriginalHMAC.Name = "lblOriginalHMAC";
            this.lblOriginalHMAC.Size = new System.Drawing.Size(123, 13);
            this.lblOriginalHMAC.TabIndex = 29;
            this.lblOriginalHMAC.Text = "Paste original file HMAC:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 159);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(506, 51);
            this.textBox1.TabIndex = 30;
            // 
            // txtHmacKey
            // 
            this.txtHmacKey.Location = new System.Drawing.Point(141, 229);
            this.txtHmacKey.Multiline = true;
            this.txtHmacKey.Name = "txtHmacKey";
            this.txtHmacKey.Size = new System.Drawing.Size(507, 51);
            this.txtHmacKey.TabIndex = 22;
            // 
            // lblHmacKey
            // 
            this.lblHmacKey.AutoSize = true;
            this.lblHmacKey.ForeColor = System.Drawing.Color.Red;
            this.lblHmacKey.Location = new System.Drawing.Point(12, 250);
            this.lblHmacKey.Name = "lblHmacKey";
            this.lblHmacKey.Size = new System.Drawing.Size(92, 13);
            this.lblHmacKey.TabIndex = 31;
            this.lblHmacKey.Text = "Paste HMAC Key:";
            // 
            // frmFilehmacvalidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(660, 394);
            this.Controls.Add(this.lblHmacKey);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblOriginalHMAC);
            this.Controls.Add(this.btnValidateFileHmac);
            this.Controls.Add(this.txtHmacValidationResult);
            this.Controls.Add(this.lblSelectedFileValue);
            this.Controls.Add(this.lblSelectedFileBaner);
            this.Controls.Add(this.btnBrowseFileToValidateHmac);
            this.Controls.Add(this.cmbHmacAlgo);
            this.Controls.Add(this.lblHmacAlgo);
            this.Controls.Add(this.txtHmacKey);
            this.Controls.Add(this.txtFileToValidateHmac);
            this.Controls.Add(this.lblSelectHmacFile);
            this.Name = "frmFilehmacvalidator";
            this.Text = "filehmacvalidator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnValidateFileHmac;
        private System.Windows.Forms.TextBox txtHmacValidationResult;
        private System.Windows.Forms.Label lblSelectedFileValue;
        private System.Windows.Forms.Label lblSelectedFileBaner;
        private System.Windows.Forms.Button btnBrowseFileToValidateHmac;
        private System.Windows.Forms.OpenFileDialog openFileToHmac;
        private System.Windows.Forms.ComboBox cmbHmacAlgo;
        private System.Windows.Forms.Label lblHmacAlgo;
        private System.Windows.Forms.TextBox txtFileToValidateHmac;
        private System.Windows.Forms.Label lblSelectHmacFile;
        private System.Windows.Forms.Label lblOriginalHMAC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtHmacKey;
        private System.Windows.Forms.Label lblHmacKey;
    }
}