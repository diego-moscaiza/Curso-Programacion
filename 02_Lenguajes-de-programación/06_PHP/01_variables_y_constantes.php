<?php
/* 1.- VARIABLES */

// Cadena de texto
$texto = "Hola mundo en PHP.";
$texto = "Aqui cambio el valor de la cadena de texto.";

// Números
$entero = 7;
$flotante = 6.59;

// Booleano
$verdadero = true;
$falso = false;

/* 2.- CONSTANTES */
const MY_CONSTANT = "Valor de la constante";

/* Imprimir datos */

// - Se puede usar echo, print y var_dump()
echo $my_string . "\n"; // Se utiliza "\n" para dar un salto de línea y que no se junte con los otros valores.
var_dump($my_string)

// - Se puede obtener el tipo de una variable
echo gettype($my_string) . "\n"; // Resultado: "Type string"

// - La siguiente linea mostrará erro al ejecutarse, porque no se pueden sumar valores numeros con texto.
echo $my_int + $my_double + $my_string . "\n";

/* Interpolacion */
// Significa que se puede imprimir un mensaje mezclado con variables y constantes.
echo "El valor de mi entero es $my_int y el de mi boolean es $my_boolean.\n";


// php.net/manual/es
// learn-php.org
?>
