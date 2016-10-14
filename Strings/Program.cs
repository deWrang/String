using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning1
            /*
            Console.WriteLine("\x56\xE4\x72\x6D\x64\xf6\x20\x47\x79\x6D\x6E\x61\x73\x69\x75\x6D");
            Console.ReadKey();
            */
            //Övning2
            /*
            Console.WriteLine("\"Hello World\"");
            Console.ReadKey();
            */
            //Övning3a
            /*
            string hello = "\"Hello World\"";
            string helloVer = hello.ToUpper();
            Console.WriteLine(helloVer);
            Console.ReadKey();
            */
            //Övning3b
            /*
            string hello = "\"Hello World\"";
            string helloGem = hello.ToLower();
            Console.WriteLine(helloGem);
            Console.ReadKey();
            */
            //Övning4
            /*
            var text = "Hello World";
            Console.WriteLine(text +" är " + text.Length + " tecken lång.");
            Console.ReadKey();
            */
            //Övning5
            /*
            Console.WriteLine("skriv in en bit text: ");
            var inmatat = Console.ReadLine();
            char[] textArray = inmatat.ToCharArray();
            
            string reverse = String.Empty;
            for (int i = textArray.Length - 1; i > -1; i--)
            {
                reverse += textArray[i];
            }
                Console.WriteLine(reverse);
            Console.ReadKey();
            */
            //Övning6
            string textMedParam = "{0} elefant{1} balanserade på en liten liten"
            + "spindeltråååd.\n"
                   + "Det tyckte {2} var så intressant,\n"
                   + "så {2} gick och hämtade en annan elefant.\n";

            string finalText = string.Format(textMedParam, "En", "", "han");
            Console.WriteLine(finalText);

            for (int i = 2; i < 10; i++)
            {
                finalText = string.Format(textMedParam, i, "er", "de");
                Console.WriteLine(finalText);
            }
            finalText = string.Format(textMedParam, "10 elefanter balanserade på en liten liten" +
                "spinderltråååd./n Det tyckte han var så intresant,/n men nu fanns det ingen annan elefant" ;


            Console.ReadKey();
        }
    }
}
