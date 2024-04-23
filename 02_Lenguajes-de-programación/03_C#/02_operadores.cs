using System;

class Program {
  public static void Main (string[] args) {

    /* Operadores */

    // 1. Operadores aritméticos
    Console.WriteLine(1 + 1); // Resultado: 2
    Console.WriteLine(1 - 1); // Resultado: 0
    Console.WriteLine(1 * 1); // Resultado: 1
    Console.WriteLine(1 / 1); // Resultado: 1
    Console.WriteLine(1 % 1); // Resultado: 0

    // 2. Operadores comparativos
    //Console.WriteLine(1 == "1"); // Da un error al comparar un entero con un texto, porque no son del mismo tipo.
    Console.WriteLine(1 == 1); // Resultado: True
    Console.WriteLine(1 != 1); // Respuesta: False
    Console.WriteLine(1 < 1); // Respuesta: False
    Console.WriteLine(1 > 1); // Respuesta: False
    Console.WriteLine(1 <= 1); // Respuesta: True
    Console.WriteLine(1 >= 1); // Respuesta: True

    // 3. Operadores lógicos
    Console.WriteLine(true && true); // Respuesta: True
    Console.WriteLine(true && false); // Respuesta: False
    Console.WriteLine(false && true); // Respuesta: False
    Console.WriteLine(false && false); // Respuesta: False

    Console.WriteLine(true || true); // Respuesta: True
    Console.WriteLine(true || false); // Respuesta: True
    Console.WriteLine(false || true); // Respuesta: True
    Console.WriteLine(false || false); // Respuesta: False

    Console.WriteLine(!true); // Respuesta: False
    Console.WriteLine(!false); // Respuesta: True
  }
}

