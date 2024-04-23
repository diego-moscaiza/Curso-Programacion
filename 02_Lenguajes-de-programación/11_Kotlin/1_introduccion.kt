// Lenguaje Kotlin
// Fue creado en la empresa Jetbrains
// - Es fuertemente tipado, pero puede inferir el dato

// - Documentacion:
// kotlinlang.org/docs/home.html
// developer.android.com/kotlin
// jetbrains.com/pages/academy/kotlin


// package main

fun main() {
    /* 1.- Variables*/

    // 1.1.- Cadena de texto
    var texto = "Una cadena de texto"
    // Cuando se cambia el valor de una variable, se muestra una advertencia
    // que dice: "la variable inicializada es redundante"
    texto = "Hola mundo!"
    println(texto) // Resultado: "Holamundo!"

    // texto = 6 // Error No se puede cambiar el valor que sea de otro tipo de dato que no sea el asignado.

    var texto_2: String = "Otra cadena de texto"
    println(texto_2)

    // 1.2.- Enteros

    var entero = 7
    entero = entero + 4
    println(entero) // 11
    println(entero - 1)
    println(entero) // 10

    var entero_2: Int = 5
    println(entero_2)

    // 1.3.- Decimales (Double, Float)

    var flotante: Float = 8.0f
    println(flotante)

    var real = 6.5
    println(real) // Resultado: 6.5

    real = 6.0
    println(real) // Se ha cambiado el valor. Resultado: 6.0

    var real_2: Double = 7.5
    println(real_2)

    // 1.4.- Booleano

    var verdadero = true
    var falso = false
    println(verdadero)
    println(falso)

    var booleano = true
    println(booleano)

    // 1.5.- Opcionales
    // Se puede definir una variable como un posible tipo de dato pero puede ser nulo.
    // Se una el operador '?' para definir como opcional un tipo de dato

    var valorOpcional: String? = null
    println(valorOpcional) // null

    // - Usando la función 'let'.
    valorOpcional.let {
        println("El valor actual de la variable es: $it") // Se usa 'it' para hacer referencia al valor de la variable
    }

    valorOpcional = "Ahora si hay texto"
    println(valorOpcional) // Resultado: "Mi valor opcional". Se imprime el nuevo valor

    valorOpcional.let {
        println("El valor actual de la variable es: $it")
    }

    /* 2.- Constantes. */
    // Se usa la palabra reservada 'val' para constantes.

    val NUMERO_DE_MESES = 12
    val TEXTO_CONSTANTE = "Una constante de tipo cadena"
    // val TEXTO_CONSTANTE = "Tratando de cambiar valor del constante" // Error.
    println(NUMERO_DE_MESES)
    println(TEXTO_CONSTANTE)

    // - Concatenación
    println("El valor de 'texto' es: " + texto);

    // - Interpolación
    println("El valor de 'entero' es $entero");
}
