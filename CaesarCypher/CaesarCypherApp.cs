using System;
namespace CaesarCypher
{
	public static class CaesarCypherApp
	{
		public static void StartApp()
		{
            //wellcoming in the app
            Console.WriteLine(">>> H5ll0!");
			Console.WriteLine(">>> W511come t0 th5 Ca5s@r Cyp5r App");
			Console.WriteLine(">>> The command to quit the app is '.exit'");
			Console.WriteLine();
			Console.WriteLine(">>> Press the enter key to continue");
			if (Console.Read() == '.')
			{
				if (Console.ReadLine() == "exit")
					return;
			}

			//presenting the instructions
            string input = ".exit";
			do
			{
                Console.WriteLine(ActionInstructions);
                Console.WriteLine();
                Console.WriteLine(">>> Introduce the right command (if it is wrong you will have to introduce it again)");
                Console.Write(">>> ");
				input = Console.ReadLine();
				if (input == "encrypt") encrypt();
                if (input == "decrypt") decrypt();
            } while (input != ".exit");

        }
		//encrypt
		private static void encrypt()
		{
			string input = null;
            //reading the encryption key
            do
            {
                Console.WriteLine("--> Now introduce the encryption key (if it is wrong you will have to introduce it again)");
                input = Console.ReadLine();
            } while (String.IsNullOrEmpty(input));

            CyperData.SetKey(input);

            //reading the normal text
            do
            {
				Console.WriteLine("--> Introduce the text that you would like to be encrypted (if it is wrong you will have to introduce it again)");
				input = Console.ReadLine();
			} while (String.IsNullOrEmpty(input));

            Console.WriteLine(CryptingAlgorithms.Encrypt(input));
            Console.WriteLine();
            Console.WriteLine(">>> Press the enter key to continue");
            Console.ReadLine();
            Console.Clear();

		}
        //decrypt
        private static void decrypt()
        {
            string input = null;
            //reading the encryption key
            do
            {
                Console.WriteLine("--> Now introduce the decryption key (if it is wrong you will have to introduce it again)");
                input = Console.ReadLine();
            } while (String.IsNullOrEmpty(input));

            CyperData.SetKey(input);

            //reading the normal text
            do
            {
                Console.WriteLine("--> Introduce the text that you would like to be decrypted (if it is wrong you will have to introduce it again)");
                input = Console.ReadLine();
            } while (String.IsNullOrEmpty(input));

            Console.WriteLine(CryptingAlgorithms.Decrypt(input));
            Console.WriteLine();
            Console.WriteLine(">>> Press the enter key to continue");
            Console.ReadLine();
            Console.Clear();
        }
        
        //constants
        private const string ActionInstructions = @">>> For the desired action enter the right command in the prompt:
for Encryption input: encrypt
for Decryption input: decrypt
for Changing a Key input: change key";

    }
}

