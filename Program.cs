using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string fraseDigitada, fraseComDislalia;
            
            Console.Write("Digite uma frase: ");
            fraseDigitada = Console.ReadLine();

            fraseComDislalia = fraseDigitada
                .Replace("r", "l")
                .Replace("R", "L");

            Console.WriteLine(fraseComDislalia);
        }
    }
}

