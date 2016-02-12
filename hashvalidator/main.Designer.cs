namespace hashvalidator
{
    partial class frmMain
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
            this.openFileToValidate = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFileSelection = new System.Windows.Forms.Label();
            this.lblHash = new System.Windows.Forms.Label();
            this.txtHashValue = new System.Windows.Forms.TextBox();
            this.lblHashAlgorithmDetected = new System.Windows.Forms.Label();
            this.cbHashAlgorithms = new System.Windows.Forms.ComboBox();
            this.btnCalculateHash = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.checkBoxHasKey = new System.Windows.Forms.CheckBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.lblSelectedFileConfirmation = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowseKeyFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileToValidate
            // 
            this.openFileToValidate.FileName = "openFile";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBrowse.Location = new System.Drawing.Point(299, 149);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(34, 31);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFileSelection
            // 
            this.lblFileSelection.AutoSize = true;
            this.lblFileSelection.Location = new System.Drawing.Point(18, 160);
            this.lblFileSelection.Name = "lblFileSelection";
            this.lblFileSelection.Size = new System.Drawing.Size(197, 20);
            this.lblFileSelection.TabIndex = 1;
            this.lblFileSelection.Text = "Select a file to validate:";
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(18, 39);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(195, 20);
            this.lblHash.TabIndex = 3;
            this.lblHash.Text = "Original file hash value:";
            // 
            // txtHashValue
            // 
            this.txtHashValue.Location = new System.Drawing.Point(299, 36);
            this.txtHashValue.Multiline = true;
            this.txtHashValue.Name = "txtHashValue";
            this.txtHashValue.Size = new System.Drawing.Size(250, 63);
            this.txtHashValue.TabIndex = 4;
            // 
            // lblHashAlgorithmDetected
            // 
            this.lblHashAlgorithmDetected.AutoSize = true;
            this.lblHashAlgorithmDetected.Location = new System.Drawing.Point(18, 114);
            this.lblHashAlgorithmDetected.Name = "lblHashAlgorithmDetected";
            this.lblHashAlgorithmDetected.Size = new System.Drawing.Size(191, 20);
            this.lblHashAlgorithmDetected.TabIndex = 5;
            this.lblHashAlgorithmDetected.Text = "Select Hash algorithm:";
            // 
            // cbHashAlgorithms
            // 
            this.cbHashAlgorithms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHashAlgorithms.ForeColor = System.Drawing.Color.DimGray;
            this.cbHashAlgorithms.FormattingEnabled = true;
            this.cbHashAlgorithms.Items.AddRange(new object[] {
            "MD5",
            "SHA-1",
            "SHA-256",
            "SHA-384",
            "SHA-512"});
            this.cbHashAlgorithms.Location = new System.Drawing.Point(299, 105);
            this.cbHashAlgorithms.Name = "cbHashAlgorithms";
            this.cbHashAlgorithms.Size = new System.Drawing.Size(121, 28);
            this.cbHashAlgorithms.TabIndex = 7;
            this.cbHashAlgorithms.Text = "--Select--";
            // 
            // btnCalculateHash
            // 
            this.btnCalculateHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateHash.ForeColor = System.Drawing.Color.DimGray;
            this.btnCalculateHash.Location = new System.Drawing.Point(695, 271);
            this.btnCalculateHash.Name = "btnCalculateHash";
            this.btnCalculateHash.Size = new System.Drawing.Size(112, 63);
            this.btnCalculateHash.TabIndex = 8;
            this.btnCalculateHash.Text = "Validate the file";
            this.btnCalculateHash.UseVisualStyleBackColor = true;
            this.btnCalculateHash.Click += new System.EventHandler(this.btnCalculateHash_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(18, 214);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(165, 20);
            this.lblKey.TabIndex = 9;
            this.lblKey.Text = "Do you have a key?";
            // 
            // checkBoxHasKey
            // 
            this.checkBoxHasKey.AutoSize = true;
            this.checkBoxHasKey.Location = new System.Drawing.Point(299, 218);
            this.checkBoxHasKey.Name = "checkBoxHasKey";
            this.checkBoxHasKey.Size = new System.Drawing.Size(15, 14);
            this.checkBoxHasKey.TabIndex = 10;
            this.checkBoxHasKey.UseVisualStyleBackColor = true;
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(6, 26);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(251, 107);
            this.txtResults.TabIndex = 12;
            this.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSelectedFileConfirmation
            // 
            this.lblSelectedFileConfirmation.AutoSize = true;
            this.lblSelectedFileConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFileConfirmation.Location = new System.Drawing.Point(339, 160);
            this.lblSelectedFileConfirmation.Name = "lblSelectedFileConfirmation";
            this.lblSelectedFileConfirmation.Size = new System.Drawing.Size(100, 13);
            this.lblSelectedFileConfirmation.TabIndex = 13;
            this.lblSelectedFileConfirmation.Text = "No file selected!";
            this.lblSelectedFileConfirmation.UseMnemonic = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseKeyFile);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHashValue);
            this.groupBox1.Controls.Add(this.lblSelectedFileConfirmation);
            this.groupBox1.Controls.Add(this.lblKey);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.lblFileSelection);
            this.groupBox1.Controls.Add(this.checkBoxHasKey);
            this.groupBox1.Controls.Add(this.lblHash);
            this.groupBox1.Controls.Add(this.lblHashAlgorithmDetected);
            this.groupBox1.Controls.Add(this.cbHashAlgorithms);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 333);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btnBrowseKeyFile
            // 
            this.btnBrowseKeyFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseKeyFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBrowseKeyFile.Location = new System.Drawing.Point(299, 264);
            this.btnBrowseKeyFile.Name = "btnBrowseKeyFile";
            this.btnBrowseKeyFile.Size = new System.Drawing.Size(34, 31);
            this.btnBrowseKeyFile.TabIndex = 15;
            this.btnBrowseKeyFile.Text = "...";
            this.btnBrowseKeyFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Select key file:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResults);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(650, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 143);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MidnightBlue;
            this.groupBox3.BackgroundImage = global::hashvalidator.Properties.Resources.bg;
            this.groupBox3.Location = new System.Drawing.Point(2, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(922, 106);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(925, 502);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCalculateHash);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "Hash Validator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileToValidate;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFileSelection;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.TextBox txtHashValue;
        private System.Windows.Forms.Label lblHashAlgorithmDetected;
        private System.Windows.Forms.ComboBox cbHashAlgorithms;
        private System.Windows.Forms.Button btnCalculateHash;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.CheckBox checkBoxHasKey;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label lblSelectedFileConfirmation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowseKeyFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

