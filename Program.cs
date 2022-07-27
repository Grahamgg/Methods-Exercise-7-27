using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise_7_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine("What is the best country?");
            //string userBcountry = Console.ReadLine();

            //Console.WriteLine("What is the worst country?");
            //string userWcountry = Console.ReadLine();

            //Console.WriteLine("What is your favorite dessert?");
            //string userDessert = Console.ReadLine();

            //Console.WriteLine($"There once was a girl named {userName}, She loved to eat {userDessert}.");
            //Console.WriteLine($"She had very poor taste in countrys as {userBcountry} only makes terrible {userDessert}");
            //Console.WriteLine($"On the other hand {userWcountry} creates the best {userDessert} in all the known universe.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2,2,4,5,6);
            Console.WriteLine($"The Sum is:{sum}");

            Console.WriteLine("Give me a number to multiply");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply with the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The Product is:{product}");
        }

        public static int Sum(params int[] list)
    {
            int sum = 0;

            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
