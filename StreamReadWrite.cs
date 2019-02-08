using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        /// Streams are used as an intermediate level between the application and the file.
        /// A StreamReader is used whenever data is required to be read from a file.
        /// A Streamwriter is used whenever data needs to be written to a file.


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = "C://test//pp.txt";

                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";

                    while((s =sr.ReadLine()) !=null)
                    {
                        Console.WriteLine(s);
                    }

                }

                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("\n My Name is Harshal Raverkar I am Software Engineer");
                }
                    Console.ReadKey();
            }
            catch(IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
