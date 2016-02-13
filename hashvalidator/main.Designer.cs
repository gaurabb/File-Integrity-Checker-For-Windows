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
            this.txtResults = new System.Windows.Forms.TextBox();
            this.lblSelectedFileConfirmation = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mstripMain = new System.Windows.Forms.MenuStrip();
            this.selectHashTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keyedHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validateFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.mstripMain.SuspendLayout();
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
            this.btnBrowse.Location = new System.Drawing.Point(141, 87);
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
            this.lblFileSelection.Location = new System.Drawing.Point(18, 97);
            this.lblFileSelection.Name = "lblFileSelection";
            this.lblFileSelection.Size = new System.Drawing.Size(117, 13);
            this.lblFileSelection.TabIndex = 1;
            this.lblFileSelection.Text = "Select a file to validate:";
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(18, 48);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(116, 13);
            this.lblHash.TabIndex = 3;
            this.lblHash.Text = "Original file hash value:";
            // 
            // txtHashValue
            // 
            this.txtHashValue.Location = new System.Drawing.Point(140, 45);
            this.txtHashValue.Multiline = true;
            this.txtHashValue.Name = "txtHashValue";
            this.txtHashValue.Size = new System.Drawing.Size(459, 35);
            this.txtHashValue.TabIndex = 4;
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
            // btnCalculateHash
            // 
            this.btnCalculateHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateHash.ForeColor = System.Drawing.Color.DimGray;
            this.btnCalculateHash.Location = new System.Drawing.Point(141, 131);
            this.btnCalculateHash.Name = "btnCalculateHash";
            this.btnCalculateHash.Size = new System.Drawing.Size(112, 63);
            this.btnCalculateHash.TabIndex = 8;
            this.btnCalculateHash.Text = "Validate the file";
            this.btnCalculateHash.UseVisualStyleBackColor = true;
            this.btnCalculateHash.Click += new System.EventHandler(this.btnCalculateHash_Click);
            // 
            // txtResults
            // 
            this.txtResults.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(276, 131);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(361, 63);
            this.txtResults.TabIndex = 12;
            this.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSelectedFileConfirmation
            // 
            this.lblSelectedFileConfirmation.AutoSize = true;
            this.lblSelectedFileConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedFileConfirmation.Location = new System.Drawing.Point(181, 102);
            this.lblSelectedFileConfirmation.Name = "lblSelectedFileConfirmation";
            this.lblSelectedFileConfirmation.Size = new System.Drawing.Size(100, 13);
            this.lblSelectedFileConfirmation.TabIndex = 13;
            this.lblSelectedFileConfirmation.Text = "No file selected!";
            this.lblSelectedFileConfirmation.UseMnemonic = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResults);
            this.groupBox1.Controls.Add(this.btnCalculateHash);
            this.groupBox1.Controls.Add(this.txtHashValue);
            this.groupBox1.Controls.Add(this.lblSelectedFileConfirmation);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.lblFileSelection);
            this.groupBox1.Controls.Add(this.lblHash);
            this.groupBox1.Controls.Add(this.lblHashAlgorithmDetected);
            this.groupBox1.Controls.Add(this.cbHashAlgorithms);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 207);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // mstripMain
            // 
            this.mstripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectHashTypeToolStripMenuItem});
            this.mstripMain.Location = new System.Drawing.Point(0, 0);
            this.mstripMain.Name = "mstripMain";
            this.mstripMain.Size = new System.Drawing.Size(676, 24);
            this.mstripMain.TabIndex = 17;
            this.mstripMain.Text = "menuStrip1";
            // 
            // selectHashTypeToolStripMenuItem
            // 
            this.selectHashTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleHashToolStripMenuItem,
            this.keyedHashToolStripMenuItem,
            this.validateFileToolStripMenuItem});
            this.selectHashTypeToolStripMenuItem.Name = "selectHashTypeToolStripMenuItem";
            this.selectHashTypeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.selectHashTypeToolStripMenuItem.Text = "Select";
            // 
            // simpleHashToolStripMenuItem
            // 
            this.simpleHashToolStripMenuItem.Name = "simpleHashToolStripMenuItem";
            this.simpleHashToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.simpleHashToolStripMenuItem.Text = "Calculate Simple Hash";
            // 
            // keyedHashToolStripMenuItem
            // 
            this.keyedHashToolStripMenuItem.Name = "keyedHashToolStripMenuItem";
            this.keyedHashToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.keyedHashToolStripMenuItem.Text = "Calculate Keyed Hash";
            this.keyedHashToolStripMenuItem.Click += new System.EventHandler(this.keyedHashToolStripMenuItem_Click);
            // 
            // validateFileToolStripMenuItem
            // 
            this.validateFileToolStripMenuItem.Name = "validateFileToolStripMenuItem";
            this.validateFileToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.validateFileToolStripMenuItem.Text = "Validate File";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(676, 247);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mstripMain);
            this.MainMenuStrip = this.mstripMain;
            this.Name = "frmMain";
            this.Text = "File Validator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mstripMain.ResumeLayout(false);
            this.mstripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label lblSelectedFileConfirmation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip mstripMain;
        private System.Windows.Forms.ToolStripMenuItem selectHashTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleHashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keyedHashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validateFileToolStripMenuItem;
    }
}

