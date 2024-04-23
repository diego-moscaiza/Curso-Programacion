// Lenguaje Swift

// - Creado en Junio de 2014 por Apple. Soporta multiples paradigmas, orientada a protocolos, orientado a objetos, funcional, imperativo, estructura de bloque, declarativo y concurrente.
// - Sirve para la creacion de aplicaciones en MacOs, iOS, iPad y los demás dispositivos de la marca Apple.


//import UIKit // Para interfaces gráficas
import Foundation // núcleo del lenguaje Swift

/* 1.- Variables. */
// Se puede declarar el tipo de dato pero el lenguaje puede inferirlo.

// 1.1.- Cadena de texto

var texto = "Esto es una cadena de texto"
texto = "Hola mundo"
// texto = 6 // Error: No se puede cambiar el tipo de dato

print(texto)

var texto_2:String = "Otra cadena de texto"
print(texto_2)

// 1.2.- Enteros

var entero = 6
print(entero + 4) // 10

entero = 15
print(entero - 1) // 14

var entero_2: Int = 5
print(entero_2)

// 1.3.- Decimales (Float, Double)

var flotante: Float = 8.32
print(flotante)

var real = 6.51382
print(real)

// 1.4.- Tipo Booleano

var verdadero = true
var falso = false

var booleano = false
print(booleano)
booleano = true // Se cambia el valor
print(booleano)

/* 2.- Constantes */
// - Las constantes se declara con "let"

let VALOR_CONSTANTE = "Valor constante"
let NUMERO_DE_MESES = 12
// VALOR_CONSTANTE = "Modificando constante" // Error

print(VALOR_CONSTANTE)
print(NUMERO_DE_MESES)
