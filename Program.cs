using System;

namespace ConsoleAppEjercicio1
{
    class Program
    {
        static void Main(string[] args)
        { //definicion de variables
                int numero1;
                int numero2;
                int suma;
            //imput
            Console.Write("introducir el primer digito:");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("introducir el segundo valor:");
            numero2 = int.Parse(Console.ReadLine());

            //proceso
            suma = numero1 + numero2;
            //resultado final
            Console.WriteLine($"la suma de: {numero1} + {numero2}= {suma}");
            Console.ReadLine();



        }
    }
}
