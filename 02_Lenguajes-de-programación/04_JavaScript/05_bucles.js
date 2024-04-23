// BUCLES //

let arreglo = [1, 2, 3, 4, 5, 6];
let entero = 100;
let emergencia = 911;

// - Usaremos una función para sumar
function sumar(a, b) { return a + b } // esta es una funcion de suma

// - Del arreglo anterior ahora se jará un recorrido y se sumará cada valor definiendo el valor a sumar
for (elemento of arreglo) {
    let suma = sumar(elemento, 5)
    console.log(suma) // se imprimira el resultado de cada suma
}

while (entero <= emergencia) {
    console.log(entero)
    entero++
}

while (true) { console.log(entero++); } // Con esto se imprimirá de uno en uno sin parar.
