using System;
using System.Linq;
using Musical_Broccoli.Encryption.Abstractions;

namespace Musical_Broccoli.Encryption
{
    public class RobberSpeechEncryption : IEncryptionStrategy
    {
        private char[] capitalConsonantLetters;
        private char[] minorConsonantLetters;

        public RobberSpeechEncryption()
        {
            var consonantsString = "bcdfghjklmnpqrstvwzx";
            capitalConsonantLetters = consonantsString.ToUpper().ToCharArray();
            minorConsonantLetters = consonantsString.ToCharArray();
        }

        public string Encrypt(string input)
        {
            var output = "";
            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];
                if (capitalConsonantLetters.Contains(currentChar))
                {
                    output = $"{output}{currentChar}o{char.ToLower(currentChar)}";
                }
                else if (minorConsonantLetters.Contains(currentChar))
                {
                    output = $"{output}{currentChar}o{currentChar}";
                }
                else
                {
                    output = $"{output}{currentChar}";
                }
            }
            return output;
        }

        public string Decrypt(string input)
        {
            var output = "";
            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];
                if (capitalConsonantLetters.Contains(currentChar) || 
                    minorConsonantLetters.Contains(currentChar))
                {
                    i += 2;
                }
                output = $"{output}{currentChar}";
            }
            return output;
        }
    }
}
