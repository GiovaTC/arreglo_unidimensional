using System;

class Program
{
    static void Main()
    {
        // Crear un arreglo unidimensional de 5 elementos
        int[] miVector = { 10, 20, 30, 40, 50 };

        // Imprimir los elementos del arreglo
        Console.WriteLine("Contenido del vector:");
        for (int i = 0; i < miVector.Length; i++)
        {
            Console.WriteLine($"Elemento [{i}] = {miVector[i]}");
        }

        //Evitar que la consola se cierre inmediatamente
        Console.WriteLine("\nPresiona una tecla para salir...");
        Console.ReadKey();
    }
}