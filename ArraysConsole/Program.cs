using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generar numeros enteros aleatorios e identificar el mayor.
            int[] enteros;
            // Cantidad de numeros generados.
            enteros = new int[50];
            Random random = new Random();
            for (int i = 0; i < enteros.Length; i++)
            {
                // Rango de los numeros generados.
                int numrandom = random.Next(0, 100);
                enteros[i] = numrandom;
            }

            // Imprimir todos los numeros generados.
            for (int i = 0; i < enteros.Length; i++)
            {
                Console.WriteLine(enteros[i]);
            }

            // Identificar el numero mas grande previamente generado.
            int maxNumber = enteros[0];
            for (int i = 0; i < enteros.Length; i++)
            {
                if (enteros[i] > maxNumber)
                {
                    maxNumber = enteros[i];
                }
            }
            Console.WriteLine("The largest number generated is: " + maxNumber);
            
            Console.ReadKey();

            // Arreglo bidimensional de strings.
            string[,] estudiantes = new string[4,2];
            estudiantes[0, 0] = "Andres";
            estudiantes[0, 1] = "Vazquez";
            estudiantes[1, 0] = "Sara";
            estudiantes[1, 1] = "Velazquez";
            estudiantes[2, 0] = "Erika";
            estudiantes[2, 1] = "Ortega";
            estudiantes[3, 0] = "Eloy";
            estudiantes[3, 1] = "Rosales";

            string apellido = estudiantes[0, 1];
            string sigapellido = estudiantes[0, 1];

            for (int i = 0; i < estudiantes.Length; i++)
            {
                if (apellido.Length<=sigapellido.Length)
                {
                    apellido = sigapellido;
                }
                if (i < 3)
                {
                    sigapellido = estudiantes[i + 1, 1];
                }
            }
            Console.WriteLine("El apellido mas largo es: " + apellido);
         
            Console.ReadKey();

            // Definir una matriz tridimensional para representar los asientos en un cine
            bool[,,] asientos = new bool[3, 5, 6]; // 3 filas, 5 columnas, 6 niveles

            // Mostrar el plano de asientos inicial
            MostrarPlanoAsientos(asientos);

            // Simulación de reserva de asientos
            ReservarAsiento(asientos, 1, 2, 3); // Reservar asiento en fila 1, columna 2, nivel 3
            ReservarAsiento(asientos, 0, 4, 2); // Reservar asiento en fila 0, columna 4, nivel 2

            // Mostrar el plano de asientos después de las reservas
            MostrarPlanoAsientos(asientos);

            Console.ReadKey();
        }
        static void MostrarPlanoAsientos(bool[,,] asientos)
        {
            Console.WriteLine("Plano de Asientos:");

            for (int nivel = 0; nivel < asientos.GetLength(2); nivel++)
            {
                Console.WriteLine($"Nivel {nivel + 1}:");
                for (int fila = 0; fila < asientos.GetLength(0); fila++)
                {
                    for (int columna = 0; columna < asientos.GetLength(1); columna++)
                    {
                        char estado = asientos[fila, columna, nivel] ? 'X' : 'O';
                        Console.Write(estado + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        static void ReservarAsiento(bool[,,] asientos, int fila, int columna, int nivel)
        {
            if (fila >= 0 && fila < asientos.GetLength(0) &&
                columna >= 0 && columna < asientos.GetLength(1) &&
                nivel >= 0 && nivel < asientos.GetLength(2))
            {
                if (!asientos[fila, columna, nivel])
                {
                    asientos[fila, columna, nivel] = true;
                    Console.WriteLine($"Asiento en fila {fila}, columna {columna}, nivel {nivel} reservado con éxito.");
                }
                else
                {
                    Console.WriteLine($"El asiento en fila {fila}, columna {columna}, nivel {nivel} ya está reservado.");
                }
            }
            else
            {
                Console.WriteLine("Ubicación de asiento inválida.");
            }
        }
    }
}
