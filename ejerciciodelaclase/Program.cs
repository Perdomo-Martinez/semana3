using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciodelaclase
{
    class Program
    {
        static void Main(string[] args)
        {
            // escribir un ciclo que permita capturar los valores
            // a almacenar en el arreglo de numbers con un tamaño de 10 

            int[] numbers = new int[9];

            for (int s = 0; s < numbers.Length; s++)
            {
                Console.WriteLine("Introduce los numeros");
                numbers[s] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Estos son los numeros numeros");
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


        }
    }
}
