# Arreglo unidimensional que imprime sus valores por consola

<img width="2550" height="1079" alt="image" src="https://github.com/user-attachments/assets/a9ea72ab-1f1d-4dfe-b930-d5dcb55fad3d" />

## ✅ Código en C#

```csharp
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

        // Evitar que la consola se cierre inmediatamente
        Console.WriteLine("\nPresiona una tecla para salir...");
        Console.ReadKey();
    }
}
🔧 Instrucciones para ejecutar en Visual Studio 2022 (C#)
Abre Visual Studio 2022.

Ve a Archivo > Nuevo > Proyecto.

Selecciona Aplicación de Consola (.NET Core) o Aplicación de Consola (.NET) en C#.

Nombra el proyecto y haz clic en Crear.

Reemplaza el contenido del archivo Program.cs con el código de arriba.

Haz clic en Iniciar (Ctrl + F5) para compilar y ejecutar.
