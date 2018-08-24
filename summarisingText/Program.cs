using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace summarisingText
{
    class Program
    {
        static void Main()
        {
            var sentence = "This is very very very very very very very very very very very very very very very very long sentence";
            var summary =  StringUtility.SummerizeText(sentence, 25);

            Console.WriteLine(summary);

            Console.ReadKey();
        }
    }
}
