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
        static  void Beolvasas()
        {
            string fajl = "otos.csv";
            StreamReader sr = null;
            using (sr = new StreamReader(fajl))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] temp = sor.Split(';');



                }

            }
        }
        
        static void Bekeres()
        {
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
        }

        static void Kiiras()
        {

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }
        }
        

        static int szam;
        static int[] szamok = new int[5];
        static void Main(string[] args)
        {
            Beolvasas();
            Bekeres();
            Kiiras();
            

           
                

               



                Console.ReadKey();
            }
        }
    }

