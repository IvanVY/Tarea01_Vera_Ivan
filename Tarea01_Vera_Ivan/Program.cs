using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea01_Vera_Ivan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1: Imprimir los números pares sin usar "if"
            Console.WriteLine("Ejercicio 1: Números pares sin usar 'if'");
            ImprimirParesSinIf();

            // Ejercicio 2: Imprimir los números pares usando "if"
            Console.WriteLine("Ejercicio 2: Números pares usando 'if'");
            ImprimirParesConIf();

            // Ejercicio 3: Imprimir los números del 1 al 50 con "Fizz", "Buzz" y "FizzBuzz"
            Console.WriteLine("Ejercicio 3: FizzBuzz");
            FizzBuzz();

            // Ejercicio 4: Imprimir los números del 1 al 10 usando un bucle "while"
            Console.WriteLine("Ejercicio 4: Números del 1 al 10 con 'while'");
            ImprimirNumeros();

            // Ejercicio 5: Calcular la suma de los primeros 100 números enteros
            Console.WriteLine("Ejercicio 5: Suma de los primeros 100 números");
            int resultadoSuma = SumarPrimeros100();
            Console.WriteLine($"La suma de los primeros 100 números es: {resultadoSuma}");

            // Ejercicio 6: Imprimir los números pares con un bucle "while"
            Console.WriteLine("Ejercicio 6: Números pares con 'while'");
            ImprimirParesWhile();
        }//fin class program

        // Ejercicio 1: Imprimir los números pares que hay dentro de los 100 primeros números enteros sin usar "if"
        static void ImprimirParesSinIf()
        {
            // Bucle que comienza en 0 y salta de 2 en 2 (sin usar "if")
            for (int i = 0; i < 100; i += 2)
            {
                Console.Write(i + " ");  // Imprime el número par
            }
            Console.WriteLine();  // Salto de línea al final
        }

        // Ejercicio 2: Imprimir los números pares que hay dentro de los 100 primeros números enteros usando "if"
        static void ImprimirParesConIf()
        {
            // Bucle que recorre los números del 0 al 99
            for (int i = 0; i < 100; i++)
            {
                // Verificamos si el número es par
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");  // Imprime el número par
                }
            }
            Console.WriteLine();  // Salto de línea al final
        }

        // Ejercicio 3: Imprimir los números del 1 al 50 con "Fizz", "Buzz" y "FizzBuzz"
        static void FizzBuzz()
        {
            // Bucle que recorre los números del 1 al 50
            for (int i = 1; i <= 50; i++)
            {
                // Verificamos si el número es divisible por 3 y 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // Verificamos si el número es divisible solo por 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // Verificamos si el número es divisible solo por 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);  // Si no es divisible ni por 3 ni por 5, imprimimos el número
                }
            }
        }

        // Ejercicio 4: Imprimir los números del 1 al 10 utilizando un bucle "while"
        static void ImprimirNumeros()
        {
            int i = 1;
            while (i <= 10)  // El bucle sigue hasta que i sea mayor que 10
            {
                Console.WriteLine(i);  // Imprime el número actual
                i++;  // Incrementa el valor de i
            }
        }

        // Ejercicio 5: Calcular la suma de los primeros 100 números enteros utilizando un bucle "while"
        static int SumarPrimeros100()
        {
            int suma = 0;
            int i = 1;
            while (i <= 100)  // El bucle sigue hasta que i sea mayor que 100
            {
                suma += i;  // Suma el valor de i a la variable suma
                i++;  // Incrementa el valor de i
            }
            return suma;  // Devuelve el valor total de la suma
        }

        // Ejercicio 6: Imprimir los números pares que hay dentro de los 100 primeros números enteros utilizando un bucle "while"
        static void ImprimirParesWhile()
        {
            int i = 0;
            while (i < 100)  // El bucle sigue hasta que i sea mayor que 99
            {
                Console.Write(i + " ");  // Imprime el número par
                i += 2;  // Incrementa i en 2 para saltar los impares
            }
            Console.WriteLine();  // Salto de línea al final
        }

    }
}
