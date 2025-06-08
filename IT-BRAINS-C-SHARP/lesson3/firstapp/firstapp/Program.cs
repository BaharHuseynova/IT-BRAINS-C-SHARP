using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa birinci ededi daxil edin:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa ikinci ededi daxil edin:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa simvolu ededi daxil edin:");
            char symbol = Convert.ToChar(Console.ReadLine());
            //1
            if (symbol == '+')
            {
                int result = num1 + num2;
                Console.WriteLine(num1 + "+" + num2 + "=" + result);
            }

            else if (symbol == '-')
            {
                int result = num1 - num2;
                Console.WriteLine(num1 + "-" + num2 + "=" + result);
            }
            else if (symbol == '*')
            {
                int result = num1 * num2;
                Console.WriteLine(num1 + "*" + num2 + "=" + result);

            }
            else if (symbol == '/')
            {
                int result = num1 / num2;
                Console.WriteLine(num1 + "/" + num2 + "=" + result);
            }
            else
            {
                Console.WriteLine("Bu ishare sistemde movcud deyil");
            }
            //2
            //int result = 0;
            //if (symbol == '+')
            //{
            //    result = num1 + num2;
            //}

            //else if (symbol == '-')
            //{
            //    result = num1 - num2;
            //}
            //else if (symbol == '*')
            //{
            //    result = num1 * num2; ;
            //}
            //else if (symbol == '/')
            //{
            //    result = num1 / num2;
            //}
            //else
            //{
            //    Console.WriteLine("Bu ishare sistemde movcud deyil");
            //}
            //Console.WriteLine(result);
            //3
            //if (symbol == '+')
            //{
            //    Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
            //}
            //else if (symbol == '-')
            //{
            //    Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
            //}
            //else if (symbol == '*')
            //{
            //    Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
            //}
            //else if (symbol == '/')
            //{
            //    Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
            //}
            //else
            //{
            //    Console.WriteLine("Bu ishare sistemde movcud deyil");
            //}
            //4
            //if (symbol == '+')
            //{
            //    Console.WriteLine(num1 + num2);
            //}
            //else if (symbol == '-')
            //{
            //    Console.WriteLine(num1 - num2);
            //}
            //else if (symbol == '*')
            //{
            //    Console.WriteLine(num1 * num2);
            //}
            //else if (symbol == '/')
            //{
            //    Console.WriteLine(num1 / num2);
            //}
            //else
            //{
            //    Console.WriteLine("Bu ishare sistemde movcud deyil");
            //}
        }
    }
}
