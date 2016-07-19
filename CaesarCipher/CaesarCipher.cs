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
        #endregion

        #region Constructor
        public CaesarCipher(string alphabet)
        {
            this.alphabet = alphabet;
        }
        #endregion

        #region Methods

        #endregion
    }
}
