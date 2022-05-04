using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            
            Console.WriteLine("Digite a letra que vc quer saber se é vogal ou não");
            letra = Convert.ToChar(Console.ReadLine());

            if (letra == 'a' || letra == 'A' || letra == 'e' || letra == 'E' || letra  == 'i' || letra == 'I' || letra == 'o' || letra == 'O' || letra == 'u' || letra == 'U'  )
            {
                Console.WriteLine("A letra que você colocou é uma consoante");
            }
            else
            {
                Console.WriteLine("A letra que você colocou não é uma consoante");
            }



        }
    }
}
