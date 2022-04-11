using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rotacion = 0;
            bool c1 = false;
            var numerosrotados = new int[7];
            int[] numeros = { 2, 4, 6, 8, 10, 12, 14 };
          
            Console.Write("Numer of rotations n: ");

            while (!c1)
            {
                c1 = Int32.TryParse(Console.ReadLine(), out rotacion);
                if (!c1) Console.Write("Not a valid number try again  ");
            }

            numerosrotados = ArregloRotacion(numeros, rotacion);
            Console.WriteLine("original array: ");
            WriteIntArray(numeros);
            Console.WriteLine($"array after {rotacion} rotations: ");
            WriteIntArray(numerosrotados);

        }

        public static void WriteIntArray(int[] arreglo) 
        {
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.Write($"{arreglo[i]} ");
            }
                
        }

        public static int[] ArregloRotacion(int[] arreglo,int rotacion) {
            int numero = arreglo.Length;
            int temporal = arreglo[0];
            int control = rotacion % numero;
            var rotado = new int[numero];

            for (int i = 0; i < numero-control; i++) 
            {
                rotado[i] = arreglo[control+i];
               // Console.Write($"{arreglo[control+i]} ");
            }

            for (int i = 0; i < control; i++)
            {
                rotado[numero-control+i] = arreglo[i];
                //Console.Write($"{arreglo[i]} ");
            }

            return rotado;
        }
    }
}


//int rotacion, numero = 0;
//bool c1 = false;

//Console.Write("Numer of integers n: ");

//while (!c1)
//{
//    c1 = Int32.TryParse(Console.ReadLine(), out numero);
//    if (!c1) Console.Write("Not a valid number try again  ");
//}
//var arreglo = new int[numero];
//var arreglorotado = new int[numero];
//Console.Write("Numer of rotations d: ");
//do
//{
//    c1 = Int32.TryParse(Console.ReadLine(), out rotacion);
//    if (!c1) Console.Write("Not a valid number try again  ");
//} while (!c1);

//int control = rotacion % numero;

//for (int i = 0; i<numero ; i++) {
//    arreglo[i] = i + 1;
//    Console.Write($"{arreglo[i]} ");
//}
//Console.WriteLine(" ");

//for (int i = 1; i <= (numero-control); i++) { 
//    arreglorotado[i-1] = control + i ;
//    Console.Write($"{arreglorotado[i-1]} ");
//}

//for (int i = 0; i < control; i++)
//{
//    arreglorotado[numero - control - 1 + i] = i + 1;
//    Console.Write($"{arreglorotado[numero - control - 1 + i]} ");
//}
