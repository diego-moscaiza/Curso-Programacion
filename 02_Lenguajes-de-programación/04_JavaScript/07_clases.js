// CLASES //
// - Las clases son azúcar sintáctico, en realidad son funciones que no permite utilizar variables no declaradas.

class Animal {
    constructor(nombre, sonido) {
        this.nombre = nombre;
        this.sonido = sonido;
    }

    hazSonido() {
        console.log('soy un ' + this.nombre + ' y mi sonido es ' + this.sonido);
        // Aqui se puede usar 'string literal'.
        //console.log(`Soy un ${this.nombre} y mi sonido es ${this.sonido}`);
    }
}

// - Creamos instancias de la clase Animal.
let perro = new Animal('perro', 'woof');
let gato = new Animal('gato', 'miau');
let tigre = new Animal('tigre', 'grrr');

// - Llamamos a la función de la clase Animal.
perro.hazSonido();
gato.hazSonido();
tigre.hazSonido();


// - La forma antigua de crear clases con métodos era usando funciones y 'prototype':

function Animals(nombre, sonido) {
    this.nombre = nombre;
    this.sonido = sonido
}

// - Añadimos un método de esta forma.
Animals.prototype.hazSonido = function () {
    console.log('soy un ' + this.nombre + ' y ' + this.sonido);
    // Aqui se puede usar 'string literal'.
    //console.log(`Soy un ${this.nombre} y mi sonido es ${this.sonido}`);
}

// - Creamos una instancia de la clase Animal.
let pajaro = new Animals('pajaro', 'silbidos');

// - Llamamos a la función de la clase Animal.
pajaro.hazSonido()
