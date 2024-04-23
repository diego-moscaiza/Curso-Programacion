// 3. Arreglos:
let numeros_1: number[] = [23, 45, 16, 37, 3, 99, 22];

let animales: string[] = ['perro', 'gato', 'tortuga'];

type mixto = string | number | boolean | string[];
let datosMixtos: mixto[] = ['texto', 69, true, ['324']];

// 4. Diccionario:
let jugadores: { [key: number]: string } = {
    10: 'Messi',
    7: 'Cristiano Ronaldo'
}

// - Podemos usar 'Record' para diccionarios.
let paises: Record<string, string> = {
    PE: 'Peru',
    EC: 'Ecuador',
    MX: 'Mexico'
}

let emails: Record<string, string[]> = {
    'Diego': ['diego@emails.com'],
    'Ricardo': ['ricardo@emails.com', 'ricardo@outlook.com']
}
