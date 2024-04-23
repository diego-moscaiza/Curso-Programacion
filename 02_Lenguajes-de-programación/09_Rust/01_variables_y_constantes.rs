/*
    Rust, lenguaje de programación alternativa a C/C++. De bajo nivel y con una eficiencia espectacular. No se tiene que manejar los punteros como C. Este lenguaje es imperativo, procedural, concurrente y funcional.
*/

// Para ejecutar un programa con rust se necesita crear una funcion con 'fn'
fn main() {
    /* 1.- Variables */

    // Rust puede inferir el dato o se le puede definir exactamente el tipo de dato.
    // Las variables en Rust sólo pueden mutar si tienen la propiedad "mut" declarada.

    // 1.1.- Textos

    // Con el tipo de cadena '&str' que es de formato UTF-8 nos permite una longitud fija y se reseva el máximo de memoria que puede almacenar una cadena de texto.*/
    let mut texto: &str = "Cadena de texto";
    texto = "Cambiando valor de la cadena"; // Cambiando el contenido del dato despues de haberlo usado

    // Imprimiendo datos
    println!("{}", texto); // Forma 1
    println!("{texto}"); // Forma 2

    // texto = 6; // No se puede cambiar el tipo de una variable declarada.

    // Con el tipo de cadena 'String' sólo utiliza la cantidad de memoria del texto.
    let texto_2: String = String::from("Otra cadena de texto");
    println!("{texto_2}");

    let texto_inferido = "texto inferido";
    println!("{}", texto_inferido);


    // 1.2.- Números

    // Los enteros tienen diversis tipos de este valor como: i8, i16, i32, i64, i128 e isize (pointer size).
    let mut entero_i32: i32 = 7;
    entero_i32 = entero_i32 + 4;
    println!("{entero_i32}"); // 11
    println!("{}", entero_i32 - 1); // 10
    println!("Este es el valor de la variable entero_i32: {}", entero_i32); // Esto sirve de ejemplo de una interpolación

    let entero_i64: i64 = 7;
    println!("{entero_i64}");


    // Los flotantes, al igual que los enteros también tienen varios tipos como f8, f16, etc.
    let flotante_f32: f32 = 8.5;
    println!("{flotante_f32}");

    let flotante_f64: f64 = 6.5;
    println!("{flotante_f64}");

    // Cuando se intenta sumar flotantes con enteros muestra error.
    // let suma_numeros = entero_i32 + flotante_f64;
    // println!("{suma_numeros}"); // Error: No se puede sumar enteros con flotantes de esta forma a pesar de ser números.

    let suma_numeros = entero_i32 as f64 + flotante_f64; // Se tiene que pasar el valor entero como flotante
    println!("La suma es: {}", suma_numeros); // Resultado: 13.5

    // 1.3.- Tipo Booleano

    let verdadero: bool = true;
    let falso: bool = false;

    println!("{verdadero}"); // false
    println!("{falso}"); // true

    let mut booleano: bool = false ;
    println!("{booleano}"); // false
    booleano = true;
    println!("{booleano}"); // true

    /* 2.- Constantes */

    // Las constantes no se puede inferir el tipo de dato.
    const NUMERO_DE_MESES: i64 = 12;
    const VALOR_CONSTANTE: &str = "Esto es texto constante";

    println!("{NUMERO_DE_MESES}");
    println!("{VALOR_CONSTANTE}");
}
