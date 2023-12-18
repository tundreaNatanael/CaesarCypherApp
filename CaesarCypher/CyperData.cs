using System;
namespace CaesarCypher
{
    public static class CyperData
    {
        /// <summary>
        /// Holds the encryption known alphabet.
        /// </summary>
        internal static string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz .,:;<>?*&%$#@!(){}[]";


        /// <summary>
        /// Holds the encryption key.
        /// </summary>
        internal static string Key { get; private set; } = "default";

        //setting the key
        internal static void SetKey(string input)
        {
            if (input == null)
                throw new ArgumentNullException("The key cannot be null");
            Key = input;
        }

        internal static string text = "KDNM>%LfQKe;%Sh!UX#*?yZESC;MwRWPPBJl!PMO,L<CGejBJyDELRNG<BQQE,FnDczAB*fK,S%%&>";

    }
}

