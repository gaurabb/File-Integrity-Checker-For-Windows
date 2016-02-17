using System;
using System.Windows.Forms;

using System.IO;

namespace hashvalidator
{
    public partial class frmSimplehashcalculator : Form
    {
        string FILE_TO_EVAL = String.Empty;
        public frmSimplehashcalculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Allows user to browse and select a file
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
                FILE_TO_EVAL = objOpenFile.FileName.ToString();
            }
        }
        /// <summary>
        /// Calculates the Hash value based on the selected algorithm and file
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
            else
            {
                //Everything is validated, so lets create an object of the Calculator Class
                ClassLibraries.calculator objCalculator = new ClassLibraries.calculator();
                string[] returnedCalculation = objCalculator.CalculateHash(FILE_TO_EVAL, cbHashAlgorithms.Text.ToString());

                if (string.Equals(returnedCalculation[0], "success"))
                {
                    txtSimpleHashValue.Text = returnedCalculation[1];
                    //Enable the "Save to file" button
                    btnSaveHashToFile.Enabled = true;
                }
                else //This block executes when their is an error
                {
                    MessageBox.Show(returnedCalculation[0]);
                }
            }
        }

        private void btnSaveHashToFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName;
                MessageBox.Show("File will be saved in the format:\n[FullFilePath: <value>\nHash:<value>]");
                //ToDo: Move all Save to file code to a seperate function
                SaveFileDialog objSaveFile = new SaveFileDialog();
                objSaveFile.Title = "Select a location to save the HMAC";
                objSaveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                objSaveFile.FileName = "FileHash";
                objSaveFile.InitialDirectory = @"C:\";
                if (objSaveFile.ShowDialog() == DialogResult.OK)
                {
                    fileName = objSaveFile.FileName;
                    File.WriteAllText(fileName, String.Format("File: " + FILE_TO_EVAL + Environment.NewLine + "Simple Hash: " + txtSimpleHashValue.Text));
                }
                else
                {
                    txtSimpleHashValue.Text = "";                    
                }
            }
            catch
            {
                MessageBox.Show("Error saving the file: Please try again!");
                return;
            }
        }
    }
}
