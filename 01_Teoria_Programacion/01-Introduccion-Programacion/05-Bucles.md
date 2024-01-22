# Bucles

Los bucles o ciclos, también conocidos como estructuras de control de flujo en la programación, permiten que se repitan las veces que se cumpla una condición determinada. Estos poseen un iterador, o sea un contador que puede incrementarse o decrementarse y es importante que tengan uno, de otra forma el bucle sería infinito.

## 1. Bucle For

La instrucción `for` es un tipo de bucle que permite repetir una instrucción o una instrucción compuesta un número especificado de veces en un iterador.

**Ejemplos:**

Usando el lenguaje Python:

```python
numeros = [1, 2, 3, 4]

for numero in numeros:
    print(numero)
```

Usando el lenguaje Java:

```java
int[] numeros = {1, 2, 3, 4};

for (int i = 0; i < numeros.length; i++) {
    System.out.println(numeros[i] + 20);
}
```

## 2. Bucle For Each

La instrucción `for each` es un tipo de bucle que permite llamar a una función proporcionada una vez por cada elemento del arreglo.

**Ejemplos:**

Usando el lenguaje JavaScript:

```javascript
const numbers = [12, 23, 1, 54, 6, 87];

numbers.forEach(function(number) {
    console.log(number);
});
```

Usando el lenguaje Java:

```java
int[] numeros = {1, 2, 3, 4};

for (int num : numeros) {
    System.out.println(num + 20);
}
```

## 2. Bucle While

La instrucción `while` es una estructura de control de flujo en la programación que se utiliza para repetir un bloque de código, mientras que se cumpla una condición determinada. En esta estructura, la condición es una expresión booleana que se evalúa en cada iteración del ciclo.

**Ejemplos:**

Usando el lenguaje Python:

```python
n = 5

while n > 0:
	print(n)
	n = n - 1
```

Usando el lenguaje Java:

```java
int entero = 100;
int emergencia = 911;

while (entero <= emergencia) {
    System.out.println(entero);
    entero++;
}
```
