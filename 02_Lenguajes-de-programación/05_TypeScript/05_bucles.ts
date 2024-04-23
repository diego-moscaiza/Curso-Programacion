/* Bucles */

// 1. Bucle for

// Ejemplo 1:
let animals:string[] = ['perro', 'gato', 'tigre'];
for (let animal of animals) {
    console.log(animal);
};

// Ejemplo 2:
let numero: number = 100;
function multiplicar1(primero : number, segundo: number): void {
    console.log(primero * segundo);
}

multiplicar1(numero, 3);

// Ejemplo 3:
let numeros_2: number[] = [23, 45, 16, 37, 3, 99, 20];
for (let numbers of numeros_2) {
    multiplicar1(numbers, 2);
}

// 2. Bucle while

// Ejemplo 1:
let emergencia: number = 911;
while (numero <= emergencia) {
    console.log(numero);
    numero++;
}
