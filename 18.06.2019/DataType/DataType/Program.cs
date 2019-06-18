using System;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte age = 127;
            age++;
            char letter = 'l';
            string str = "aynur";
            bool t = false;
            float d = 3.54F;
            decimal x = 1.578855M;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            //foreach (var let in str)
            //{
            //    Console.WriteLine(let);
            //}
            //if (t)
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            switch (str)
            {
                case "Shirvan":
                    Console.WriteLine("Yes Shirvan");
                    break;
                case "Aynur":
                    Console.WriteLine("Yes Shirvan2");
                    break;
                default:
                    Console.WriteLine("Shirvan bu yasha catmaz: " + age);
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
