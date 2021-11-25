using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello world";
            string str2 = "Academy step";
            string str3 = "Aleksey Shaimov";
            Console.WriteLine(str1 + " " + str2 + " " + str3);
            string str4 = str2+ str3;
            Console.WriteLine(str4);

            int key = String.Compare(str1, str2);
            if (key == -1)
                Console.WriteLine(str1 + "\n" + str2);
            if (key == 1)
                Console.WriteLine(str2 + "\n" + str1);
        }
    }
}
