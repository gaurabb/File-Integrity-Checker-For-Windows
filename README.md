# Simple Hash Operations in Windows

## Functions that it can be used for:

1. Calculate simple hash for a given file
2. Verify file against provided simple hash/checksum
3. Calculate and save random 128-bit key
4. Generate HMAC for a file (key can be provided or it can generate a key for the user)

**Following simple algorithms are supported:**
* MD5
* SHA1
* SHA256
* SHA384
* SHA512

**Following HMAC implementations that are supported:**
* HMACMD5
* HMACRIPEMD160
* HMACSHA1
* HMACSHA256
* HMACSHA384
* HMACSHA512

##  How to use?
1. **Method 1:** Download the EXE from the "Application" folder.
2. **Method 2:** Clone the repo and open the solution file in Visual Studio. If you can do this, you will know how to run the file


## To Do:
1. Verify a file against provided HMAC (key needed) - *this is not yet implemented*
2. Open functionality windows within a parent window, instead of opening as multiple seperate windows.