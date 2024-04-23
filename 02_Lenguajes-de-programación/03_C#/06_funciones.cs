using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    /* Funciones */

    // - Ejemplo 1:
    int sumar(int primero, int segundo)
    {
        return primero + segundo;
    }

    int resultado = sumar(1, 4);
    Console.WriteLine(resultado); // Resultado: 5


    // - Ejemplo 2:
    int numero = 23;

    // No retorna ningun valor, ejecuta lo que se ha ingresado. Esta es una función pura.
    void multiplicar(int primero, int segundo)
    {
        Console.WriteLine(primero + segundo);
    }

    multiplicar(numero, 2); // Resultado: 25


    // - Ejemplo 3:

    String[] animales = { "perro", "gato", "tortuga" };

    void PrintFirstElement(string[] lista)
    {
        Console.WriteLine(lista[0]);
    }

    PrintFirstElement(animales);  // Resultado: perro


    // - Ejemplo 4: Función quicksort:
    List<int> quicksort(List<int> lista)
    {
        if (lista.Count <= 1)
        {
            return lista;
        }

        int pivote = lista[0];
        List<int> izquierda = new List<int>();
        List<int> derecha = new List<int>();

        int i;
        for (i = 1; i < lista.Count; i++)
        {
            if (lista[i] < pivote) {
                izquierda.Add(lista[i]);
            }
            else
            {
                derecha.Add(lista[i]);
            }
        }

        List<int> primero = quicksort(izquierda);
        List<int> medio = new List<int> { pivote };
        List<int> segundo = quicksort(derecha);

        primero.AddRange(medio);
        primero.AddRange(segundo);
        return primero;
    }

    List<int> numeros2 = new List<int> { 23, 45, 16, 37, 3, 99,22 };
    List<int> listaOrdenada = quicksort(numeros2);
    Console.WriteLine(string.Join(", ", listaOrdenada)); // Resultado: 3, 16, 22, 23, 37, 45, 99
  }
}
