// 1. ECMA SCRIPT
/* - Javascript es manejado por la especificación de ECMASCRIPT y en la actualidad se usan las versiones ES6 y posteriores.
   - ES6 o también conocida como ES2015 ya que se declara la especificación por año y no por número de versión. */

/* 1.- VARIABLES */

// Cadenas de texto
let mensaje = "Hola mundo";
let libro = "Clean Code";
let telf = "345-654-654";
let color = "amarillo";

// Números
let entero = 1232;
let decimal = 1.92;

// Booleanos
let verdadero = true;
let falso = false;

// Indefinido y nulo
let sinDefinir = undefined;
let nulo = null;

/* 2.- CONSTANTES */

const PI = 3.14159265359;

// Imprimir datos por consola
console.log(mensaje);

// RENDERIZACIÓN DE DATOS

// - Muestra texto en la pagina web.
document.write('texto');

// - Muestra una alerta con lo que tiene el parámetro.
alert('Texto');


// SCOPE EN JAVASCRIPT
/* - El Scope se refiere al alcance de una variable en un documento de JS, el cual se define con los nombres 'var' y 'let', para el alcance global y local respectivamente.*/

var totalAlcance = "Variable global"; // No se suele usar
let alcanceLimitado = "Variable local"; // El estandar actual para definir variables
