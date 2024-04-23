// Estrcuturas de datos

// 1. Arreglo
let arreglo = [1, 2, 3, 4, 5, 6]

// 2. Diccionario:
// - Es un objeto con formato de clave : valor
let jugadores = {
    10: 'Messi',
    7: 'Cristiano Ronaldo'
}

let emails = {
    'Juan': ['juan@gmail.com'],
    'Ricardo': [
        'ricardo@gmail.com',
        'ricardo@hotmail.com'
    ]
}

let lenguaje = {
    nombre: 'Javascript',
    año: 1995,
    descripcion: function () {
        // Aqui estamos usando el 'string literal'.
        console.log(`${this.nombre} fue creado en ${this.año}`)
    }
}

lenguaje.descripcion() // Llamando la funciñon del diccionario 'lenguaje'

