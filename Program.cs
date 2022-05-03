using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            char a;

            Console.WriteLine("Digite uma letra: ");
            a = Convert.ToChar(Console.ReadLine());

            if ( 'a' == a || 'e' == a || 'i'== a || 'o'== a || 'u' == a )
            {
                Console.WriteLine("Esta é uma vogal");
            }
            else
            {
                Console.WriteLine("Esta é uma consoante");
            }

        }
    }
}
