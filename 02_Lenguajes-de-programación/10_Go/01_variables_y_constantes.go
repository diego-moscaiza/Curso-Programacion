// Go. Lenguaje de programacion compilado de bajo nivel, relativamente reciente y esta en un posicion alta en TIOBE.
// Este lenguaje se usa en los ambitos de servidor, backend, microservicios, aplicaciones de redes, scripting y linea de comandos. Puede usarse en sistemas operativos.

// Declaracion del paquete principalpackage main
package main

// Importacion de funciones
import (
	"fmt"
	"reflect"
)

// Se debe crear un modulo con "go mod init -name"

// Para ejecutar código en Go se debe crear la funcion main
func main() {
	/* 1.- Variables */
	// No se puede declarar variables sin usarlas
	// Las variables se les puede definir el tipo de dato y también se puede inferirlo.

	// 1.1.- Texto

	// Forma 1
	var saludo string = "Hola mundo"

	// Forma 2
	var texto string
	texto = "Esto es una cadena"
	texto = "Aqui cambio el valor de la cadena"

	// Imprimir datos
	fmt.Println(saludo)
	fmt.Println(texto) // Se imprime el valor modificado

	// texto = 6 // Error. No se puede modificar el valor con un tipo diferente de dato.

	var texto_2 string = "Otra cadena de texto"
	fmt.Println(texto_2)

	// Inferencia de datos.
	// De esta forma de infiere los tipos de datos de a variables en GO
	// No se escribe "var" ni el tipo de dato
	texto_3 := "Esto es una cadena de texto"
	fmt.Println(texto_3)

	// 1.2.- Números
	// Hay diferentes tipos de enteros.

	var entero int = 7 // Cuando se declara el tipo "int", por defecto es int64.
	entero = entero + 4
	fmt.Println(entero)
	fmt.Println(entero - 1) // Realizando operacion resta
	fmt.Println(entero)     // 11. Se imprime el valor de la variable modificado con la operacion resta

	// fmt.Print(texto + string(entero)) // Error 'Print' no se puede concatenar valores.
	fmt.Println(texto, entero)       // Con 'Println' permite concatenar valores.
	fmt.Println(reflect.TypeOf(entero)) //int64

	var flotante = 6.5 // Por defecto es de tipo 'float64'
	fmt.Println(flotante)
	fmt.Println(reflect.TypeOf(flotante)) // float64

	fmt.Println(entero + int(flotante)) // Se puede sumar numeros cambiando su tipo de datos
	fmt.Println(flotante + float64(entero))
	fmt.Println(float64(entero) + flotante)

	// 1.3.- Booleanos
	var verdadero bool = true
	var falso bool = false

	fmt.Println(verdadero) // true
	fmt.Println(falso) // false

	var booleano bool = false
	fmt.Println(booleano) // false
	booleano = true // Se modifica el tipo de buleano
	fmt.Println(booleano) // true

	/* 2.-Constantes */
	// Las constantes no muestran error si no las usas.
	// Las constantes si pueden inferir el tipo de dato en GO

	const NUMERO_DE_MESES int = 12
	const VALOR_CONSTANTE string = "Esto es texto constante"
	fmt.Println(NUMERO_DE_MESES)
	fmt.Println(VALOR_CONSTANTE)
}

// - go.dev/learn.
// - lear-microsoft/es-es-/training/paths/go-first-step.
