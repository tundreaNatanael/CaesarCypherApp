using System;
namespace CaesarCypher
{
	public static class CryptingAlgorithms
	{
        //Encryption

            //the verification
        public static string Encrypt(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException("Input cannot be null or empty");
            return encrypt(input);
        }

            //the algorithm
        private static string encrypt(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                int key = i % CyperData.Key.Length;
                int swiftKey = 0;
                for (int k = 0; k < CyperData.Alphabet.Length; k++)
                {
                    if (CyperData.Key[key] == CyperData.Alphabet[k])
                    {
                        swiftKey = k;
                        break;
                    }
                }

                for (int k = 0; k < CyperData.Alphabet.Length; k++)
                {
                    if (input[i] == CyperData.Alphabet[k])
                    {
                        output += CyperData.Alphabet[(k + swiftKey) % CyperData.Alphabet.Length];
                        break;

                    }

                }
            }
            return output;
        }

        //Decryption

            //the verification
        public static string Decrypt(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException("Input cannot be null or empty");
            return decrypt(input);
        }

        //the algorithm
            
        private static string decrypt(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                int key = i % CyperData.Key.Length;
                int swiftKey = 0;
                for (int k = 0; k < CyperData.Alphabet.Length; k++)
                {
                    if (CyperData.Key[key] == CyperData.Alphabet[k])
                    {
                        swiftKey = k;
                        break;
                    }
                }

                for (int k = 0; k < CyperData.Alphabet.Length; k++)
                {
                    if (input[i] == CyperData.Alphabet[k])
                    {
                        if ((k - swiftKey) >= 0)
                            output += CyperData.Alphabet[(k - swiftKey) % CyperData.Alphabet.Length];
                        else
                            output += CyperData.Alphabet[CyperData.Alphabet.Length + k - swiftKey];
                        break;

                    }

                }
            }
            return output;

        }
    }
}

