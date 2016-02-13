#  File Hash Validator
#### Validates a file's hash to confirm if the file content has been changed
#### Windows only

##  What can it do?
Calculate a file's hash value using one of the following algorithms:
* MD5
* SHA1
* SHA256
* SHA384
* SHA512

If an original file hash value is provided, compares the value with calculated value and shows if they match.
if an original file hash value is not provided, the tool displays the calculated hash of the file.

It can also be used to generate a HMAC with a key that the user provides or the tool generates (that the user can 
save as a text file.)
**HMAC implementations that are supported:**
* HMACMD5
* HMACRIPEMD160
* HMACSHA1
* HMACSHA256
* HMACSHA384
* HMACSHA512

##  How to use?
1. **Method 1:** Download the EXE from the "Application" folder.
2. **Method 2:** Clone the repo and open the solution file in Visual Studio. If you can do this, you will know how to run the file
