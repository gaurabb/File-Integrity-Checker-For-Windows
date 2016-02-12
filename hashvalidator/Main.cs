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
            if (objOpenFile.ShowDialog() == DialogResult.OK)
            {
                lblSelectedFileConfirmation.Text = objOpenFile.FileName.ToString();
                //txtInformationSupplied.Text = txtInformationSupplied.Text + Environment.NewLine + objOpenFile.FileName.ToString();    
            }
            FILE_TO_EVAL = objOpenFile.FileName.ToString();
        }

        #region Commented_Code

        /// <summary>
        /// Calculate the hash value based on the hash algorith type  selected by the user
        /// Default to SHA1
        /// </summary>
        /// <param name="file">file to get the hash of</param>
        /// <param name="hashAlgo">hash algorithm to use</param>
        //private void CalculateHash(string file, string hashAlgo)
        //{
        //    string caseSwitch = hashAlgo; 
        //    string hashValue = String.Empty;
        //    FileStream fileStream = File.Open(file, FileMode.Open);
        //    fileStream.Position = 0;
        //    try
        //    {
        //        switch (caseSwitch)
        //        {
        //            case "MD5":
        //                MD5 objMd5 = new MD5CryptoServiceProvider();
        //                hashValue = BitConverter.ToString(objMd5.ComputeHash(fileStream)).Replace("-", String.Empty).ToLower();
        //                break;
        //            case "SHA-256":
        //                SHA256 objSha256 = new SHA256CryptoServiceProvider();
        //                hashValue = BitConverter.ToString(objSha256.ComputeHash(fileStream)).Replace("-", String.Empty).ToLower();
        //                break;
        //            case "SHA-384":
        //                SHA384 objSha384 = new SHA384CryptoServiceProvider();
        //                hashValue = BitConverter.ToString(objSha384.ComputeHash(fileStream)).Replace("-", String.Empty).ToLower();
        //                break;
        //            default:
        //                SHA1 objSha1 = new SHA1CryptoServiceProvider();
        //                hashValue = BitConverter.ToString(objSha1.ComputeHash(fileStream)).Replace("-", String.Empty).ToLower();
        //                break;
        //        }
        //        if (String.IsNullOrEmpty(txtHashValue.Text))
        //        {
        //            txtResults.Text = hashValue;
        //        }
        //        else
        //        {
        //            if (String.Equals(hashValue, txtHashValue.Text))
        //            {
        //                txtResults.BackColor = System.Drawing.Color.Green;
        //                txtResults.Text = "Valid File!!!";
        //            }
        //            else
        //            {
        //                txtResults.BackColor = System.Drawing.Color.Red;
        //                txtResults.Text = "Invalid File!!";
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error calculating the hash. Please try again.");
        //    }
        //    finally
        //    {
        //        fileStream.Close();
        //    }
        //}

        /// <summary>
        /// Calculates the HMAC based on key provided and the HMAC algorithm selected by the user
        /// Defaults to HMACSHA1
        /// </summary>
        /// <param name="file">file to get the HMAC of</param>
        /// <param name="hmacAlgo">HMAC algorithm to use</param>
        /// <param name="hmacKey">Key supplied by the user</param>
        //private void CalculateHMAC(string file, string hmacAlgo, string hmacKey)
        //{

        //}

        #endregion

        /// <summary>
        /// Start the hash calculation process. Triggers when the user clicks on 
        /// "Validate the file" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateHash_Click(object sender, EventArgs e)
        {
            //Get the hash algorithm selected by the user
            // if nothing selected show a message to select one
            // Same for file to calculate the hash of
            if (cbHashAlgorithms.Text == "--Select--")
            {
                MessageBox.Show("Select a hash algorithm");
            }
            else if (String.IsNullOrEmpty(FILE_TO_EVAL))
            {
                MessageBox.Show("Select a file to verify");
            }
            //Everything is validated, so lets create an object of the Calculator Class
            ClassLibraries.calculator objCalculator = new ClassLibraries.calculator();
            string[] returnedCalculation = objCalculator.CalculateHash(FILE_TO_EVAL, cbHashAlgorithms.Text.ToString());

            if (string.Equals(returnedCalculation[0], "success"))
            {
                if (String.IsNullOrEmpty(txtHashValue.Text))
                {
                    txtResults.Text = returnedCalculation[1];
                }
                else if (String.Equals(returnedCalculation[1], txtHashValue.Text))
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
            else //This block executes when their is an error
            {
                MessageBox.Show(returnedCalculation[1]);
            }
        }
    }
}
