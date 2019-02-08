using System;

namespace ConsoleApplication13
{
    /* Static is a modifier in C# which is applicatble for the
     * class , variables, Methods, Constructor
     *
     * when a member is decleared static , it can be accessed with the name of its class directaly.
     *
     * A static class is decleared with the help of static keyword. A static class can only cantain static data memeners
     * static method can be access with name of its class directaly
     *
     * 
     */
    
    
        class Tutorial
        {
            static public int ten = 104;

            public static void total()
            {
                Console.WriteLine("Total number of national parks"+"present in india {0}",ten);
            }
        }
        internal class Program
        {
        
        public static void Main(string[] args)
        {
            Tutorial.total();
           
        }
    }
}
