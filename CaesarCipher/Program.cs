﻿using System;
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
            Console.WriteLine(caeserCipher.Cypher("hello there"));
        }
    }
}
