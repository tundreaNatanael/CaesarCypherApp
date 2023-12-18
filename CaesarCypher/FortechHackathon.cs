using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
/*
             Pași de Decodificare:
                - Eliminați caracterele "^" și "~" din text.
                - Înlocuiți caracterele "{", "}", "(", ")" cu spații.
                - Înlocuiți cifrele cu literele corespunzătoare.
                - Inversați ordinea caracterelor rămase în text.
                - Înlocuiți caracterele cu literele corespunzătoare, utilizând cheia Constants.Key.
                  Cheia este folosita in cadrul unui algoritm de criptare cu substitutie, alfabetul suportat fiind specificat in Constants.Alphabet.
                - Afișați mesajul rezultat.
             */



// TODO: implement decryption

namespace CaesarCypher
{
    public static class FortechHackathon
    {
        public static void StartFortechProblem()
        {
            Console.WriteLine(FortechHackathon.Task1(Constants.encryptedText));
        }

        private static string Task1(string text)
        {
            text = text.Replace("^", "");
            text = text.Replace("~", "");
            return Task2(text);
        }

        private static string Task2(string text)
        {
            text = text.Replace("{", " ");
            text = text.Replace("}", " ");
            text = text.Replace("(", " ");
            text = text.Replace(")", " ");
            return Task3(text);
        }

        private static string Task3(string text)
        {
            for (char i = '0'; i <= '9'; i++)
            {
                char j = Convert.ToChar(i + 'A' - '0');
                text = text.Replace(i, j);
            }

            return Task4(text);
        }

        private static string Task4(string input)
        {
            string output = "";
            int inputIndex = input.Length - 1;
            for (int i = 0; i < input.Length; i++)
            {
                output = output + input[inputIndex];
                inputIndex--;
            }

            return Task5(output);
        }

        private static string Task5(string input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                int key = i % Constants.Key.Length;
                int swiftKey = 0;
                for (int k = 0; k < Constants.Alphabet.Length; k++)
                {
                    if (Constants.Key[key] == Constants.Alphabet[k])
                    {
                        swiftKey = k;
                        break;
                    }
                }

                for (int k = 0; k < Constants.Alphabet.Length; k++)
                {
                    if (input[i] == Constants.Alphabet[k])
                    {
                        if ((k - swiftKey) >= 0)
                            output += Constants.Alphabet[(k - swiftKey) % Constants.Alphabet.Length];
                        else
                            output += Constants.Alphabet[Constants.Alphabet.Length + k - swiftKey];
                        break;

                    }

                }
            }
            return output;

        }
    }
}

