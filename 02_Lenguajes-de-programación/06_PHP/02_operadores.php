<?php

// OPERADORES

$a = 15;
$b = 45;

// 1. Operadores Aritmeticos

echo $a + $b ."\n";   // Resultado: 60
echo $a - $b ."\n";   // Resultado: -30
echo $a * $b ."\n";   // Resultado: 675
echo $a / $b ."\n";   // Resultado: 0.33333333333333
echo $a % $b ."\n";   // Resultado: 15
echo $a ** $b ."\n";  // Resultado: 8.3966617312138E+52

// 2. Operadores comparativos

var_dump($a == $b); // Resultado: bool(false)
var_dump($a != $b); // Resultado: bool(true)
var_dump($a > $b);  // Resultado: bool(false)
var_dump($a < $b);  // Resultado: boll(true)
var_dump($a >= $b); // Resultado: boll(false)
var_dump($a <= $b); // Resultado: boll(true)

// 3. Operadores lógicos

$verdadero = true;
$falso = false;

// Operador NOT (!)

var_dump( !$verdadero ); // Resultado: bool(false)
var_dump( !$falso );     // Resultado: bool(true)

// Operador AND (&&)
var_dump( $verdadero && $verdadero ); // Resultado: bool(true)
var_dump( $verdadero && $falso ); // Resultado: bool(false)
var_dump( $falso && $verdadero ); // Resultado: bool(false)
var_dump( $verdadero && $falso ); // Resultado: bool(false)

// Operador OR (||)
var_dump( $verdadero || $verdadero ); // Resultado: bool(true)
var_dump( $verdadero || $falso ); // Resultado: bool(true)
var_dump( $falso || $verdadero ); // Resultado: bool(true)
var_dump( $falso || $falso ); // Resultado: bool(false)

// Operadore XOR
// true si $a o $b es true, pero no ambos.
var_dump( $verdadero xor $verdadero ); // Resultado: bool(false)
var_dump( $verdadero xor $falso ); // Resultado: bool(true)
var_dump( $falso xor $verdadero ); // Resultado: bool(true)
var_dump( $falso xor $falso ); // Resultado: bool(false)


// 9. Operadores de comparación de igualdad y no igualdad
var_dump($a == $b); // Resultado: true
var_dump($a != $b); // Resultado: false

// 7. Operadores de comparación de identidad

var_dump($a === $b); // Resultado: true
var_dump($a !== $b); // Resultado: false



// 4. Operadores de asignación

$a += $b; // Resultado: 30
$a -= $b; // Resultado: -10
$a *= $b; // Resultado: 200
$a /= $b; // Resultado: 0.5
$a %= $b; // Resultado: 10

// 5. Operadores de incremento y decremento

$a++; // Resultado: 11
$b--; // Resultado: 19


// 5. Operadores de concatenación

$hola = "Hola";
$mundo = "Mundo";

echo $hola . " " . $mundo."\n"; // Resultado: Hola Mundo

// 6. Operadores de asignación de concatenación

echo $hola .= $mundo."\n"; // Resultado: HolaMundo
