/* Funciones */

// Ejemplo 1:
function sumar(primero: number, segundo: number): number {
    return primero + segundo;
}

sumar(3,4);
console.log(sumar)

// Ejemplo 2:
let entero_1: number = 100;
function multiplicar(primero : number, segundo: number): void {
    console.log(primero * segundo);
}

multiplicar(entero_1, 3)

// Ejemplo 3:
let animals_1:string[] = ['perro', 'gato', 'tigre'];
function printFirstElemet(arreglo: any[]): void {
    console.log(arreglo[0]);
}

printFirstElemet(animals_1)

// Ejemplo 4: Función quicksort.
function quicksort(arreglo: number[]): number[] {
    if (arreglo.length <= 1) {
        return arreglo;
    };

    let pivote = arreglo[0];
    let izquierda: number[] = [];
    let derecha: number[] = [];

    let i = 1
    for (i; i < arreglo.length; i++) {
        arreglo[i] < pivote
        ? izquierda.push(arreglo[i])
        : derecha.push(arreglo[i]);
    };

    return quicksort(izquierda).concat(pivote, quicksort(derecha));
};

let numbers: number[] = [23, 45, 16, 37, 3, 99, 22];
let listOrdenada: number[] = quicksort(numbers);
console.log(listOrdenada);
