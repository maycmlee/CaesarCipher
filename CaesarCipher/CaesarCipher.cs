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
            offset = rand.Next(0, 10);
            Console.WriteLine(offset);
        }

        // Loops through a string of characters and .
        public string Cypher(string text)
        {
            string ciphered = "";
            for(int i = 0; i < text.Length; i++)
            {
                ciphered += FindOffsetLetter(text[i], false);
            }
            return ciphered;
        }

        public string Decipher(string text)
        {
            string decipher = "";
            for(int i = 0; i < text.Length; i++)
            {
                decipher += FindOffsetLetter(text[i], true);
            }

            return decipher;
        }
        #endregion

        #region Helper Methods
        //Finds letter in alphabet and returns offset letter
        public char FindOffsetLetter(char letter, bool decipher)
        {
            if (decipher)
            {
                offset = -Math.Abs(offset);
            }
            char newLetter = ' ';
            for(int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == letter)
                {
                Console.WriteLine("Offset: {0}", offset);
                    newLetter = alphabet[(i + offset) % alphabet.Length];
                }
            }
            return newLetter;
        }
        #endregion
    }
}
