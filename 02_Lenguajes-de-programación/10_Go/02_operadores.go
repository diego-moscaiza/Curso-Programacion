package main

import "fmt"

func main() {
    var numero_1 int64 = 10
    var numero_2 int64 = 5

    // Operadores

    // Operadores Aritmñeticos
    fmt.Println("Suma = ", numero_1 + numero_2)
    fmt.Println("Resta = ", numero_1 - numero_2)
    fmt.Println("Multiplicación = ", numero_1 * numero_2)
    fmt.Println("División = ", numero_1 / numero_2)
    fmt.Println("Residuo = ", numero_1 % numero_2)

    // Operadores Comparativos
    fmt.Println("10 y 5 son iguales : ", numero_1 == numero_2)
    fmt.Println("10 y 5 no son iguales : ", numero_1 != numero_2)
    fmt.Println("10 es MAYOR que 5: ", numero_1 > numero_2)
    fmt.Println("10 es MENOR que 5: ", numero_1 < numero_2)
    fmt.Println("10 es MAYOR IGUAL que 5: ", numero_1 >= numero_2)
    fmt.Println("10 es MENOR IGUAL que 5: ", numero_1 <= numero_2)

    // 3. Operadores Lógicos
    var verdadero bool = true
    var verdadero_1 bool = true
    var falso bool = false
    var falso_1 bool = false

    fmt.Println("Verdadero y Verdadero es : ", verdadero && verdadero_1);
    fmt.Println("Verdadero y Falso es : ", verdadero && falso);
    fmt.Println("Falso y Verdadero es : ", falso && verdadero);
    fmt.Println("Falso y Falso es : ", falso && falso_1);

    fmt.Println("Verdadero o Verdadero es : ", verdadero || verdadero_1);
    fmt.Println("Verdadero o Falso es : ", verdadero || falso);
    fmt.Println("Falso o Verdadero es : ", falso || verdadero);
    fmt.Println("Falso o Falso es : ", falso || falso_1);

    fmt.Println("Negación de Verdadero es : ", !verdadero);
    fmt.Println("Negación de Falso es : ", !falso);

    // 4. Operadores de incremento y decremento
    numero_1++ // Incrementa 1 unidad
    fmt.Println("numero_1 =", numero_1)

    numero_2-- // Decrementa 1 unidad
    fmt.Println("numero_2 =", numero_2)
}
