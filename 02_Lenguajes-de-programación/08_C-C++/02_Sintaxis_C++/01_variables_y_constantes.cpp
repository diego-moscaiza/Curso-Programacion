#include <iostream>

int main() {
    /* 1.- VARIABLES */

    // - Textos
    char caracter = 'A'; // caractér
    std::string saludo = "Hello World!"; // cadena de texto

    // - Números
    int entero = 10;
    float flotante = 12.3f; // punto flotante de precisión simple
    double real = 12.3456789; // coma flotante de doble precisión

    // - Booleanos
    bool verdadero = true;
    bool falso = false;

    /* 2.- CONSTANTES */
    const int NUMBER_OF_MONTHS = 12;
    const float PI = 3.14159265358979323846;

    // Imprimir datos
    std::cout << "Caractér: " << caracter << std::endl;
    std::cout << "Cadena de texto: " << saludo << std::endl;
    std::cout << "Entero: " << entero << std::endl;
    std::cout << "Flotante: " << flotante << std::endl;
    std::cout << "Real: " << real << std::endl;
    std::cout << "Booleano: " << verdadero << std::endl;

    cout << "Numero de meses: " << NUMBER_OF_MONTHS;
    cout << "Numero PI: " << PI;

    return 0;
}
