using System;

class Program {
  public static void Main (string[] args) {

    /* Bucles */

    // 1. For

    for (int i = 0; i < 3; i++)
    {
        Console.Write(i);
    }

    // 2. Foreach

    // - Ejemplo 1:
    string[] animales = { "perro", "gato", "tigre" };

    foreach (string animal in animales)
    {
        Console.WriteLine(animal);
    }

    // - Ejemplo 2:

    void multiplicar(int primero, int segundo)
    {
        Console.WriteLine(primero * segundo);
    }

    int[] listaNumeros =  { 23, 45, 16, 37, 3, 99,22 };

    foreach (int numero in listaNumeros)
    {
        multiplicar(numero, 2);
    }

    // 3. While

    int entero = 100;
    int emergencia = 911;

    while (entero <= emergencia)
    {
        Console.WriteLine(entero);
        entero++; // Resultado: 100, 101, 102, 103, ... 911
    }

    // 4. Do While

    int valorInicial = 0;
    do
    {
        Console.Write(valorInicial);
        valorInicial++;
    } while (valorInicial < 5);
    // Output: 01234
  }
}
