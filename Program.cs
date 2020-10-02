using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lotto1
{
    class Program
    {
        static int szam;
        static void Main(string[] args)
        {
            int[] szamok = new int[5];
            int szam;

            string fajl = "otos.csv";
            StreamReader sr = null;
            using (sr = new StreamReader(fajl))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    

                }

                for (int i = 0; i < szamok.Length; i++)
                {
                    Console.WriteLine("Kérek egy számot! ");
                    szam = int.Parse(Console.ReadLine());
                    if (szam > 0 && szam <= 90)
                    {
                        szamok[i] = szam;
                    }
                    else
                    {
                        Console.WriteLine("0-és 90 között kell bekérni! Adj meg másik számot! ");
                        szam = int.Parse(Console.ReadLine());
                        szamok[i] = szam;
                    }
                }

                for (int i = 0; i < szamok.Length; i++)
                {
                    Console.WriteLine(szamok[i]);
                }


                Console.ReadKey();
            }
        }
    }
}
