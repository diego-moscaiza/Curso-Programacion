using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {

    /* Listas */

    // 1. Arreglo (Array):
    int[] numeros = { 23, 45, 16, 37, 3, 99, 22 };
    //numeros[0];

    Console.WriteLine(numeros[0]); // Resultado: 23

    // 2. Lista:

    List<int> numbers = new List<int>{ 23, 45, 16, 37, 3, 99, 22 };
    //Console.WriteLine(numbers[0])
    Console.WriteLine(string.Join(", ", numbers)); // Resultado: 23, 45, 16, 37, 3, 99, 22

    // - Ejemplo: Arreglo de texto:
    String[] animales = { "perro", "gato", "tortuga" };

    // - Ejemplo: Arreglo de datos mixtos.
    dynamic[] datosMixtos = { "texto", 69, true, animales };


    // 3. Diccionarios

    // - Ejemplo 1:
    Dictionary<int, string> jugadores = new Dictionary<int, string>();
    jugadores.Add(10, "Messi");
    jugadores.Add(7, "Cristiano Ronaldo");
    Console.WriteLine(jugadores[7]); // Resultado: Cristiano Ronaldo

    // - Ejemplo 2:
    Dictionary<string, string> paises = new Dictionary<string, string>();
    paises.Add("PE", "Perú");
    paises.Add("EC", "Ecuador");
    paises.Add("EU", "Estados Unidos");
    paises.Add("ES", "España");

    Console.WriteLine(paises["PE"]); // Resultado: Perú

    // - Ejemplo 3:
    Dictionary<string, string[]> emails = new Dictionary<string, string[]>();
    String[] emailsDiego = {"diego@email.com"};
    emails.Add("Diego", emailsDiego);
    String[] emailsJuan = {"juan@email.com", "juan@outlook.com"};
    emails.Add("Juan", emailsJuan);

  }
}
