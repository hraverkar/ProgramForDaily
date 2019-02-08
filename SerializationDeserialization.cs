using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp1
{
    // Serialization and Deserialization Concept
    /* This concept used when you want to send data from one application to another.
       Serialization is used to export application data into a file. 
       The destination application then uses deserialization to 
       extract the data from the application for further use.*/
       
       
    [Serializable]
    class Program
    {
        public int ID;
        public string Name;

        static void Main(string[] args)
        {
            try
            {
                var path = "C://test//qq.txt";
                Program pr = new Program
                {
                    ID = 101,
                    Name = "Harshal Raverkar"
                };

                IFormatter fr = new BinaryFormatter();

                Stream sm = new FileStream(path,FileMode.Create,FileAccess.Write);
                fr.Serialize(sm, pr);
                sm.Close();

                sm = new FileStream(path, FileMode.Open, FileAccess.Read);
                Program ObjectNew = (Program)fr.Deserialize(sm);

                Console.WriteLine(ObjectNew.ID);
                Console.WriteLine(ObjectNew.Name);

                Console.ReadKey();
            }
            catch(IOException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
