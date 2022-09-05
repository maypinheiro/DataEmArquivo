
using System;
using System.IO;

namespace ArquivoData
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"c:\File\Arquivo1.txt";
            try
            {
                Console.Write("Diguite a Data: ");
                var entrada = Console.ReadLine();
                DateTime data = DateTime.Parse(entrada);
                var formato1 = data.ToString("MM/dd/yy");
                var formato2 = data.ToString("yy/MM/dd");
                var formato3 = data.ToString("dd-MM-yy");

                Console.WriteLine(formato1);
                Console.WriteLine(formato2);
                Console.WriteLine(formato3);

                using (StreamWriter writetext = new StreamWriter(path))
                {
                    writetext.WriteLine(formato1);
                    writetext.WriteLine(formato2);
                    writetext.WriteLine(formato3);
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Formato de data Invalido!");
            }
        }
    }
}
