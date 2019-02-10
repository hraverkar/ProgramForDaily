    {
        public static void Main()
        {
            int[] a = {1, 2, 0, 0};
            const int p = 34;
            var result= intergerChange(a);
            var test = result + p;
            var l= ChageInterger(test);
            foreach (var VARIABLE in l)
            {
                Console.WriteLine(VARIABLE);
            }
        }

        private static IList<int> ChageInterger(int i)
        {
        return i.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray();
        }

        private static int intergerChange(IReadOnlyList<int> b)
        {
            var a= b.Count;
            var temp = 0;
            for (var i = 0; i < a; i++)
            {
                temp = 10 * temp + b[i];       
            }
            return temp;
        }
        
    }
