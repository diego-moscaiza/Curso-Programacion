/* Lenguaje de programación Java.
- Este lenguaje de programación fue creado en 1995 por James Gosling y se utiliza en casi todos los campos como aplicaciones de escritorio, móvil, financieras, de comercio electrónico, empresariales, distribuidas o de Big Data. */


// Todos los archivos de java estan dentro de un paquete
package Paquete;

/* Clases */
// - Para ejecutar codigo de java debe existir siempre una clase con el nombre del archivo

public class Main {
    // Dentro debe tener un método estático como es que está a continuación:.
    public static void main(String[] args) {

        /* 1.- VARIABLES */

        // - Cadenas de texto
        String saludo = "Hola mundo";
        String libro = "Clean Code";
        String telf = "987-965-921";
        String color = "rojo";

        // - Números
        int entero = 100;
        double decimal = 1.93456;

        // - Booleanos
        boolean autorizado = true;
        boolean seleccionado = false;

        /* 2.- CONSTANTES */

        final double PI = 3.14159;

        // Imprimir datos
        System.out.println(saludo);
    }
}

