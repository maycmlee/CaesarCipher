using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            CaesarCipher caeserCipher = new CaesarCipher("abcdefghijklmnopqrstuvwxyz");
            caeserCipher.SetOffset();
            string text = "hello there";
            Console.WriteLine("Original text: {0}", text);
            Console.WriteLine("Secret Code: {0}", caeserCipher.Cypher(text));
        }
    }
}
