using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    /// <summary>
    /// This class receives an alphabet in the constructor and has three methods:
    /// 1. Sets an offset for ciphering
    /// 2. Cyphers a string with the given alphabet and current offset
    /// 3. Deciphers a string with given alphbet and current offset
    /// </summary>
    class CaesarCipher
    {

        #region Properties
        public string alphabet;
        public int offset;
        #endregion

        #region Constructor
        public CaesarCipher(string alphabet)
        {
            this.alphabet = alphabet;
        }
        #endregion

        #region Methods
        // Generates random number for offset
        public void SetOffset()
        {
            Random rand = new Random();
            offset = rand.Next(0, 6);
        }

        // Cyphers a string with given alphabet and current offset.
        public string Cypher(string text)
        {
            string ciphered = "";
            // Go through each letter in text
            for(int i = 0; i < text.Length; i++)
            {
                ciphered += FindLetterInAlphabet(text[i]);
            }
            // Find letter in alphabet

            // Find offset letter and add to new string.
            return ciphered;
        }
        #endregion

        #region Helper Methods
        public char FindLetterInAlphabet(char letter)
        {
            for(int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == letter)
                {
                    return alphabet[i + offset];
                }
            }

            throw new System.ArgumentException("Letter not found in alphabet");
        }
        #endregion


    }
}
