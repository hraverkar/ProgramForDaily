
// File name Geek2.cs
using System;

namespace ConsoleApp12
{
    public partial class Geeks
    {
        public void Display()
        {
            Console.WriteLine("Author Name is " + _name);
            Console.WriteLine("Number is " + _number);
        }       
    }   
}



// File name Geek1.cs

namespace ConsoleApp12
{
    public partial class Geeks
    {
        private readonly string _name;
        private readonly int _number;

        public Geeks(string a, int b)
        {
            this._name = a;
            this._number = b;
        }      

    }
    
    public static class Test
        {
            public static void Main()
            {
                var gk = new Geeks("Harshal" , 25);
                gk.Display();
            }
        }
}
