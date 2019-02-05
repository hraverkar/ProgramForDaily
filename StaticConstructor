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
    internal class Tutorial
    {
        static Tutorial()
        {
            Console.WriteLine("Example of Static Constructor");
        }


        private Tutorial(int t)
        {
            Console.WriteLine("Instance Constructor " + t);
        }

        private static string TutorialDetails(string Name, string Branch)
        {
            return "Name:" + Name + "Branch:" + Branch;

        }

        public static void Main(string[] args)
        {
            var obj = new Tutorial(1);
            Console.WriteLine(TutorialDetails("Harshal","Bangalore"));
            var tt = new Tutorial(2);
            
            Console.WriteLine(TutorialDetails("Vikas","Testingg"));

        }
    }
}
