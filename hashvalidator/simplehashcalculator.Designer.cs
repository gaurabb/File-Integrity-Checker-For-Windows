namespace hashvalidator
{
    partial class frmSimplehashcalculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSimpleHashValue = new System.Windows.Forms.TextBox();
            this.btnCalculateHash = new System.Windows.Forms.Button();
            this.lblSelectedFileConfirmation = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFileSelection = new System.Windows.Forms.Label();
            this.lblHashAlgorithmDetected = new System.Windows.Forms.Label();
            this.cbHashAlgorithms = new System.Windows.Forms.ComboBox();
            this.lblSimpleHashValue = new System.Windows.Forms.Label();
            this.btnSaveHashToFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveHashToFile);
            this.groupBox1.Controls.Add(this.lblSimpleHashValue);
            this.groupBox1.Controls.Add(this.txtSimpleHashValue);
            this.groupBox1.Controls.Add(this.btnCalculateHash);
            this.groupBox1.Controls.Add(this.lblSelectedFileConfirmation);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.lblFileSelection);
            this.groupBox1.Controls.Add(this.lblHashAlgorithmDetected);
            this.groupBox1.Controls.Add(this.cbHashAlgorithms);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 247);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // txtSimpleHashValue
            // 
            this.txtSimpleHashValue.BackColor = System.Drawing.SystemColors.Window;
            this.txtSimpleHashValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSimpleHashValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSimpleHashValue.Location = new System.Drawing.Point(140, 96);
            this.txtSimpleHashValue.Multiline = true;
            this.txtSimpleHashValue.Name = "txtSimpleHashValue";
            this.txtSimpleHashValue.ReadOnly = true;
            this.txtSimpleHashValue.Size = new System.Drawing.Size(500, 63);
            this.txtSimpleHashValue.TabIndex = 12;
            // 
            // btnCalculateHash
            // 
            this.btnCalculateHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateHash.ForeColor = System.Drawing.Color.DimGray;
            this.btnCalculateHash.Location = new System.Drawing.Point(140, 177);
            this.btnCalculateHash.Name = "btnCalculateHash";
            this.btnCalculateHash.Size = new System.Drawing.Size(112, 24);
            this.btnCalculateHash.TabIndex = 8;
            this.btnCalculateHash.Text = "Generate Hash";
            this.btnCalculateHash.UseVisualStyleBackColor = true;
            this.btnCalculateHash.Click += new System.EventHandler(this.btnCalculateHash_Click);
            // 
            // lblSelectedFileConfirmation
            // 
            this.lblSelectedFileConfirmation.AutoSize = true;
            this.lblSelectedFileConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFileConfirmation.Location = new System.Drawing.Point(230, 66);
            this.lblSelectedFileConfirmation.Name = "lblSelectedFileConfirmation";
            this.lblSelectedFileConfirmation.Size = new System.Drawing.Size(100, 13);
            this.lblSelectedFileConfirmation.TabIndex = 13;
            this.lblSelectedFileConfirmation.Text = "No file selected!";
            this.lblSelectedFileConfirmation.UseMnemonic = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBrowse.Location = new System.Drawing.Point(190, 51);
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
            this.lblFileSelection.Location = new System.Drawing.Point(18, 61);
            this.lblFileSelection.Name = "lblFileSelection";
            this.lblFileSelection.Size = new System.Drawing.Size(166, 13);
            this.lblFileSelection.TabIndex = 1;
            this.lblFileSelection.Text = "Select a file to generate the hash:";
            // 
            // lblHashAlgorithmDetected
            // 
            this.lblHashAlgorithmDetected.AutoSize = true;
            this.lblHashAlgorithmDetected.Location = new System.Drawing.Point(18, 27);
            this.lblHashAlgorithmDetected.Name = "lblHashAlgorithmDetected";
            this.lblHashAlgorithmDetected.Size = new System.Drawing.Size(113, 13);
            this.lblHashAlgorithmDetected.TabIndex = 5;
            this.lblHashAlgorithmDetected.Text = "Select Hash algorithm:";
            // 
            // cbHashAlgorithms
            // 
            this.cbHashAlgorithms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHashAlgorithms.ForeColor = System.Drawing.Color.DimGray;
            this.cbHashAlgorithms.FormattingEnabled = true;
            this.cbHashAlgorithms.Items.AddRange(new object[] {
            "MD5",
            "SHA-1",
            "SHA-256",
            "SHA-384",
            "SHA-512"});
            this.cbHashAlgorithms.Location = new System.Drawing.Point(140, 19);
            this.cbHashAlgorithms.Name = "cbHashAlgorithms";
            this.cbHashAlgorithms.Size = new System.Drawing.Size(121, 21);
            this.cbHashAlgorithms.TabIndex = 7;
            this.cbHashAlgorithms.Text = "--Select--";
            // 
            // lblSimpleHashValue
            // 
            this.lblSimpleHashValue.AutoSize = true;
            this.lblSimpleHashValue.Location = new System.Drawing.Point(18, 111);
            this.lblSimpleHashValue.Name = "lblSimpleHashValue";
            this.lblSimpleHashValue.Size = new System.Drawing.Size(69, 13);
            this.lblSimpleHashValue.TabIndex = 14;
            this.lblSimpleHashValue.Text = "Simple Hash:";
            // 
            // btnSaveHashToFile
            // 
            this.btnSaveHashToFile.Enabled = false;
            this.btnSaveHashToFile.Location = new System.Drawing.Point(273, 177);
            this.btnSaveHashToFile.Name = "btnSaveHashToFile";
            this.btnSaveHashToFile.Size = new System.Drawing.Size(107, 23);
            this.btnSaveHashToFile.TabIndex = 15;
            this.btnSaveHashToFile.Text = "Save to file...";
            this.btnSaveHashToFile.UseVisualStyleBackColor = true;
            this.btnSaveHashToFile.Click += new System.EventHandler(this.btnSaveHashToFile_Click);
            // 
            // frmSimplehashcalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 257);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSimplehashcalculator";
            this.Text = "Calculate Simple File Hash";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSimpleHashValue;
        private System.Windows.Forms.Button btnCalculateHash;
        private System.Windows.Forms.Label lblSelectedFileConfirmation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFileSelection;
        private System.Windows.Forms.Label lblHashAlgorithmDetected;
        private System.Windows.Forms.ComboBox cbHashAlgorithms;
        private System.Windows.Forms.Label lblSimpleHashValue;
        private System.Windows.Forms.Button btnSaveHashToFile;
    }
}