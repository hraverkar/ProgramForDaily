using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "C://test/qq.txt";
            if (File.Exists("C://test//pp.txt") != true)
                return;

       
            string ppr = File.ReadAllText("C://test//pp.txt");
            Console.WriteLine(ppr);
            Console.ReadKey();

            //System.IO.File.Copy("C://test//pp.txt","C://test//qq.txt");

            //System.IO.File.Delete("C://test//qq.txt");
           

            if (File.Exists(path) != true)
            {
                File.Create(path);
                using (StreamWriter w = File.AppendText(path))
                {
                    w.WriteLine("Hello Mr. Harshal Raverkar");
                    w.Close();
                }
                
                
                
                /*string[] str = System.IO.File.ReadAllLines("C://test//pp.txt");
                }
                foreach (var a in str)
                {
                    Console.WriteLine(a);

                    Console.ReadKey();
                }*/
            }
        }
    }
}
