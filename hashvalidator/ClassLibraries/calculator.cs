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
        string HMAC_ERROR = "Error calculating HMAC: Please try again";        
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
        /// Computes a keyed hash for a source file based on key provided and the HMAC algorithm selected by the user
        /// Defaults to HMACSHA1
        /// </summary>
        /// <param name="file">file to get the HMAC of</param>
        /// <param name="hmacAlgo">HMAC algorithm to use</param>
        /// <param name="hmacKey">Key supplied by the user</param>
        public string CalculateHMAC(string file, string hmacAlgo, byte[] hmacKey)
        {
            string resultHmac = "";
            byte[] hashOfInputFile;
            try
            {
                switch (hmacAlgo)
                {
                    case "HMACMD5":
                        using (HMACMD5 hmacSha1 = new HMACMD5(hmacKey))
                        {
                            using (FileStream objFS = new FileStream(file, FileMode.Open))
                            {
                                // Computing the hash of the input file
                                hashOfInputFile = hmacSha1.ComputeHash(objFS);
                            }
                        }
                        break;
                    case "HMACSHA256":
                        using (HMACSHA256 hmacSha1 = new HMACSHA256(hmacKey))
                        {
                            using (FileStream objFS = new FileStream(file, FileMode.Open))
                            {
                                // Computing the hash of the input file
                                hashOfInputFile = hmacSha1.ComputeHash(objFS);
                            }
                        }
                        break;
                    case "HMACSHA384":
                        using (HMACSHA384 hmacSha1 = new HMACSHA384(hmacKey))
                        {
                            using (FileStream objFS = new FileStream(file, FileMode.Open))
                            {
                                // Computing the hash of the input file
                                hashOfInputFile = hmacSha1.ComputeHash(objFS);
                            }
                        }
                        break;
                    case "HMACSHA512":
                        using (HMACSHA512 hmacSha1 = new HMACSHA512(hmacKey))
                        {
                            using (FileStream objFS = new FileStream(file, FileMode.Open))
                            {
                                // Computing the hash of the input file
                                hashOfInputFile = hmacSha1.ComputeHash(objFS);
                            }
                        }
                        break;
                    case "HMACRIPEMD160":
                        using (HMACRIPEMD160 hmacSha1 = new HMACRIPEMD160(hmacKey))
                        {
                            using (FileStream objFS = new FileStream(file, FileMode.Open))
                            {
                                // Computing the hash of the input file
                                hashOfInputFile = hmacSha1.ComputeHash(objFS);
                            }
                        }
                        break;
                    default:// "HMACSHA1":
                        using (HMACSHA1 hmacSha1 = new HMACSHA1(hmacKey))
                        {
                            using(FileStream objFS = new FileStream(file, FileMode.Open))
                            {
                                // Computing the hash of the input file
                                hashOfInputFile = hmacSha1.ComputeHash(objFS);
                            }
                        }
                        break;
                }
                resultHmac = BitConverter.ToString(hashOfInputFile).Replace("-", String.Empty).ToLower();
                return resultHmac;
             }
            catch
            {
                resultHmac = HMAC_ERROR;
                return resultHmac;
            }
            finally
            {

            }
        }

        /// <summary>
        /// Generates a random key and returns the key value
        /// </summary>
        /// <returns></returns>
        public byte[] GenerateRandomKey()
        {
            //string randomStrongKey;
            byte[] randomKey = new byte[128];
            using (RandomNumberGenerator randomGen = new RNGCryptoServiceProvider())
            {
                randomGen.GetBytes(randomKey);
            }
            return randomKey;
        }
    }
}
