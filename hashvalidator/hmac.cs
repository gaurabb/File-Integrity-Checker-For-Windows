using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.IO;
using hashvalidator;

namespace hashvalidator
{
    public partial class frmHmac : Form
    {
        //Global Residents :)
        string FILE_TO_HMAC;
        byte[] RANDOM_KEY_BYTES;
        string KEYGEN_ERROR_MSG = "Error calculating the key. Please uncheck and check again.";
        string HMAC_ERROR = "Error calculating HMAC: Please try again";

        public frmHmac()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method will be used to Save a newly generated HMAC value in a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveHmacToFile_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Not implemented yet!");
            try
            {
                string fileName;
                MessageBox.Show("File will be saved in the format:\n[FullFilePath: <>\nKey:<>\nHMAC:<>]");
                //ToDo: Move all Save to file code to a seperate function
                SaveFileDialog objSaveFile = new SaveFileDialog();
                objSaveFile.Title = "Select a location to save the HMAC";
                objSaveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                objSaveFile.FileName = "FileHMAC-";
                objSaveFile.InitialDirectory = @"C:\";
                if (objSaveFile.ShowDialog() == DialogResult.OK)
                {
                    fileName = objSaveFile.FileName;
                    File.WriteAllText(fileName, String.Format("File: " + txtFileToHmac.Text + Environment.NewLine + "Key: " + txtHmacKey.Text + Environment.NewLine + "HMAC: " + txtHmacValue.Text));
                }
                else
                {
                    txtHmacKey.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Error saving the file: Please try again!");
                return;
            }
        }

        /// <summary>
        /// This method will be used to open the file for which the HMAC has to be calculated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowseFileToHmac_Click(object sender, EventArgs e)
        {
            string selectedFile;
            OpenFileDialog objOpenFileToHmac = new OpenFileDialog();
            objOpenFileToHmac.Title = "Select a file to calculate HMAC";
            if (objOpenFileToHmac.ShowDialog() == DialogResult.OK)
            {
                selectedFile = objOpenFileToHmac.FileName.ToString();
                lblSelectedFileValue.Text = selectedFile;
                txtFileToHmac.Text = selectedFile;
                FILE_TO_HMAC = selectedFile;
            }
            else
            {
                //do nothing for now
            }
        }

        private void txtFileToHmac_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFileToHmac.Text))
            {
                lblSelectedFileValue.Text = txtFileToHmac.Text;
            }
            else
            {
                lblSelectedFileValue.Text = "No file selected!";
            }
        }

        /// <summary>
        /// This method handles the user event on clicking the "Generate key" checkbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbGenerateKey_CheckedChanged(object sender, EventArgs e)
        {
            if (txtHmacKey.Text != String.Empty && cbGenerateKey.Checked != true)
            {
                MessageBoxButtons choices = MessageBoxButtons.YesNo;
                DialogResult userChoice = MessageBox.Show("Do you want to save the key?", "Please confirm?", choices);
                if (userChoice == DialogResult.Yes)
                {
                    try
                    {
                        string fileName;
                        //ToDo: Move all Save to file code to a seperate function
                        SaveFileDialog objSaveFile = new SaveFileDialog();
                        objSaveFile.Title = "Select a location to save the key";
                        objSaveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                        objSaveFile.FileName = "KEY";
                        objSaveFile.InitialDirectory = @"C:\";
                        if (objSaveFile.ShowDialog() == DialogResult.OK)
                        {
                            fileName = objSaveFile.FileName;
                            File.WriteAllText(fileName, txtHmacKey.Text);
                            txtHmacKey.Text = "";
                        }
                        else
                        {
                            txtHmacKey.Text = "";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error: Please try again!");
                        return;
                    }
                }
                else
                {
                    txtHmacKey.Text = "";
                }
            }

            if (cbGenerateKey.Checked == true && txtHmacKey.Text == String.Empty)
            {
                ClassLibraries.calculator objGenKey = new ClassLibraries.calculator();
                RANDOM_KEY_BYTES = objGenKey.GenerateRandomKey();
                if (RANDOM_KEY_BYTES != null)
                {
                    txtHmacKey.Text = BitConverter.ToString(RANDOM_KEY_BYTES).Replace("-", String.Empty).ToLower();
                }
                else
                {
                    MessageBox.Show(KEYGEN_ERROR_MSG);
                }
            }
        }

        /// <summary>
        /// This method handles the initial validation of parameters for the HMAC genenaration process
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcHmac_Click(object sender, EventArgs e)
        {
            //Validate that the following values are available:
            //1) HMAC algorithm is selected
            //2) File 
            //3) Key
            if (cmbHmacAlgo.Text == "--Select--" || String.IsNullOrEmpty(txtFileToHmac.Text) || String.IsNullOrEmpty(txtHmacKey.Text))
            {
                MessageBox.Show("All the fields in RED must be selected!");
            }
            else
            {
                // If all goes well, pass the values to the CalculateHMAC function in hashvalidator.ClassLibraries.calculator class
                // Too much input validation is intentionally avoided
                ClassLibraries.calculator objCalc = new ClassLibraries.calculator();
                string HMACResult = objCalc.CalculateHMAC(txtFileToHmac.Text, cmbHmacAlgo.Text, RANDOM_KEY_BYTES);
                if (!String.IsNullOrEmpty(HMACResult) && !String.Equals(HMACResult, HMAC_ERROR))
                {
                    txtHmacValue.Text = HMACResult;
                }
                else
                {
                    MessageBox.Show(HMACResult);
                }
            }
        }
    }
}
