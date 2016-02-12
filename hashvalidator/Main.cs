using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;

namespace hashvalidator
{
    public partial class frmMain : Form
    {
        string FILE_TO_EVAL;
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get the file to calculate the Hash for
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog objOpenFile = new OpenFileDialog();
            objOpenFile.Title = "Select a file to validate";
            if(objOpenFile.ShowDialog() == DialogResult.OK)
            {
               lblSelectedFileConfirmation.Text = objOpenFile.FileName.ToString();    
                //txtInformationSupplied.Text = txtInformationSupplied.Text + Environment.NewLine + objOpenFile.FileName.ToString();    
            }
            FILE_TO_EVAL = objOpenFile.FileName.ToString();
        }

        /// <summary>
        /// Calculate the hash value based on the hash value selected by the user
        /// Default to SHA1
        /// </summary>
        /// <param name="file">the name of the file to get the hash of</param>
        /// <param name="hashAlgo">hash algorithm to use</param>
        private void CalculateHash(string file, string hashAlgo)
        {
            string caseSwitch = hashAlgo; 
            string hashValue = String.Empty;
            FileStream fileStream = File.Open(file, FileMode.Open);
            fileStream.Position = 0;
            try
            {
                switch (caseSwitch)
                {
                    case "MD5":
                        MD5 objMd5 = new MD5CryptoServiceProvider();
                        hashValue = BitConverter.ToString(objMd5.ComputeHash(fileStream)).Replace("-", String.Empty).ToLower();
                        break;
                    case "SHA-256":
                        SHA256 objSha256 = new SHA256CryptoServiceProvider();
                        hashValue = BitConverter.ToString(objSha256.ComputeHash(fileStream)).Replace("-", String.Empty).ToLower();
                        break;
                    case "SHA-384":
                        SHA384 objSha384 = new SHA384CryptoServiceProvider();
                        hashValue = BitConverter.ToString(objSha384.ComputeHash(fileStream)).Replace("-", String.Empty).ToLower();
                        break;
                    default:
                        SHA1 objSha1 = new SHA1CryptoServiceProvider();
                        hashValue = BitConverter.ToString(objSha1.ComputeHash(fileStream)).Replace("-", String.Empty).ToLower();
                        break;
                }
                if (String.IsNullOrEmpty(txtHashValue.Text))
                {
                    txtResults.Text = hashValue;
                }
                else
                {
                    if (String.Equals(hashValue, txtHashValue.Text))
                    {
                        txtResults.BackColor = System.Drawing.Color.Green;
                        txtResults.Text = "Valid File!!!";
                    }
                    else
                    {
                        txtResults.BackColor = System.Drawing.Color.Red;
                        txtResults.Text = "Invalid File!!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating the hash. Please try again.");
            }
            finally
            {
                fileStream.Close();
            }
        }

        
        /// <summary>
        /// Start the hash calculation process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateHash_Click(object sender, EventArgs e)
        {
            //Get the hash algorithm
            if (cbHashAlgorithms.Text == "--Select--")
            {
                MessageBox.Show("Select a hash algorithm");
            }
             else if(String.IsNullOrEmpty(FILE_TO_EVAL))
            {
                MessageBox.Show("Select a file to verify");
            }
            else
            {
                CalculateHash(FILE_TO_EVAL, cbHashAlgorithms.Text.ToString());
            }
        }

               
    }
}
