fn main() {
    let numero_1 = 10;
    let numero_2 = 3;

    // 1. Operadores Aritméticos
    let suma = numero_1 + numero_2;
    let resta = numero_1 - numero_2;
    let multiplicacion = numero_1 * numero_2;
    let division = numero_1 / numero_2;
    let residuo = numero_1 % numero_2;

    // 2. Operadores Comparativos
    let mayor_que = numero_1 < numero_2;
    let menor_que = numero_1 > numero_2;

    // 3. Operadores Lógicos
    let and = true && false; // Operador AND
    let or = true || false; // Operador OR
    let not = !true; // Operador NOT

    // Impresión de datos:
    println!("Suma: {}", suma);
    println!("Resta: {}", resta);
    println!("Multiplicación: {}", multiplicacion);
    println!("Division: {}", division);
    println!("Residuo: {}", residuo);

    println!("10 es MAYOR que 3: {}", mayor_que);
    println!("10 es MENOR que 3: {}", menor_que);

    println!("AND: {}", and);
    println!("OR: {}", or);
    println!("NOT: {}", not);
}
