using System;


using System.Security.Cryptography;
using System.IO;

namespace hashvalidator.ClassLibraries
{
    class calculator
    {

        #region GLOBAL_VALUES
        string[] resultToReturn;
        string SUCCESS = "success";
        string FAIL = "fail";
        string ERROR_MSG = "Error calculating the hash. Please try again.";
        string KEYGEN_ERROR_MSG = "Error calculating the key. Please uncheck and check again.";
        #endregion
        /// <summary>
        /// Calculate the hash value based on the hash algorith type  selected by the user
        /// Default to SHA1
        /// </summary>
        /// <param name="file">file to get the hash of</param>
        /// <param name="hashAlgo">hash algorithm to use</param>
        public string[] CalculateHash(string file, string hashAlgo)
        {
            string caseSwitch = hashAlgo;
            resultToReturn = new string[2];
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

                resultToReturn[0] = SUCCESS;
                resultToReturn[1] = hashValue;
            }
            catch
            {
                resultToReturn[0] = FAIL;
                resultToReturn[1] = ERROR_MSG;                
            }
            finally
            {
                fileStream.Close();
            }

            return resultToReturn;
        }

        /// <summary>
        /// Calculates the HMAC based on key provided and the HMAC algorithm selected by the user
        /// Defaults to HMACSHA1
        /// </summary>
        /// <param name="file">file to get the HMAC of</param>
        /// <param name="hmacAlgo">HMAC algorithm to use</param>
        /// <param name="hmacKey">Key supplied by the user</param>
        public void CalculateHMAC(string file, string hmacAlgo, string hmacKey)
        {
            //frmHmac.ActiveForm = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GenerateRandomKey()
        {
            string randomStrongKey;
            byte[] randomKey = new byte[128];
            using (RandomNumberGenerator randomGen = new RNGCryptoServiceProvider())
            {
                randomGen.GetBytes(randomKey);
            }
            if(randomKey != null)
            {
                randomStrongKey = BitConverter.ToString(randomKey).Replace("-", String.Empty).ToLower();
            }
            else
            {
                randomStrongKey = KEYGEN_ERROR_MSG;
            }
            return randomStrongKey;
        }
    }
}
