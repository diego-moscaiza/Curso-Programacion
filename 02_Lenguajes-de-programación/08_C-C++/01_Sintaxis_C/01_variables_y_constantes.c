#include <stdio.h>

int main() {
    /* 1.- VARIABLES */

    // - Textos
    char caracter = 'A'; // caractér
    char saludo[] = "Hello World!"; // cadena de texto

    // - Números
    int entero = 10;
    float flotante = 12.3;
    double real = 12.3456789;

    // - Booleanos
    bool verdadero = true;
    bool falso = false;

    /* 2.- CONSTANTES */
    const int NUMERO_DE_MESES = 12;
    const float PI = 3.14159265358979323846;

    // Imprimir datos
    printf("Caractér: %c\n", caracter);
    printf("Cadena de texto: %s\n", saludo);
    printf("Entero: %d\n", entero);
    printf("Flotante: %f\n", flotante);
    printf("Real: %lf\n", real);
    printf("Hay %d meses en un año.\n", NUMERO_DE_MESES);
    printf("El valor de PI es %.10f.\n", PI);

    return 0;
}
