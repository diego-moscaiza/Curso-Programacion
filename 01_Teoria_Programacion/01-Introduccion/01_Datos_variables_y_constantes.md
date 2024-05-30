# Datos

Un dato es la información sobre algo específico, como la información de una persona donde se ven su nombre y apellidos, su edad y etc.

En programación, para poder definir los datos existen dos formas de hacerlo, mediante variables o constantes.
Para definir variables y constantes se debe escribir el nombre del dato y luego asignarle un valor con el símbolo igual `=`.

**Restricciones acerca de nombrar variables y constantes:**
1. No debe iniciar con un número.
2. No debe llevar caracteres especiales, salvo el guión `-` y el guión bajo `_`.
3. De debe preferencia, no colocar tilde a las palabras que sí los llevan.
4. No debe tener espacios si el nombre se compone de varias palabras.
5. No debe llevar el nombre de las palabras reservadas del lenguaje.

## 1. Variables

Una variable se caracteriza por nombre que se refiere a un dato o valor y para crear una no es necesario utilizar una palabra reservada del lenguaje. Se les llama sí porque tiene ca la capacidad de manipular el valor de estos en el tiempo.

**Ejemplos:**

Variables con Python:

```python
# Cree una varriable que almacene la edad de un usuario que tiene 20 años:
edad_usuario = 20

# Cree una varriable que almacene un mensaje de bienvenida:
mensaje = "Bienvenido"
```

## 2. Constantes

Una constante es similar a la variable solo que esta no cambia su valor.


**Ejemplos:**

Con el lenguaje Java se usa la palabra reservada `final`:

```java
final int PI = 3.1416;
```

Con el lenguaje Javascript se usa la palabra reservada `const`:

```javascript
const PI = 3.1416;
```

Con el lenguaje Python se usa la convención `UPPER_SNAKE_CASE`:

```python
HORAS_DIA = 24;
```

## (Extra): Comentarios

En los lenguajes de programación se puede realizar comentarios al código para dejar una descripción o un mensaje breve. Se puede comentar el mismo código con el propósito de que no se ejecute esa porción de código. Algunos lenguajes de programación manejan una misma forma de crear comentarios y en otros puede variar.

**Ejemplos:**

**1. Comentarios en Java:**

```java
// Colocando dos veces el símbolo de slash al inicio se crea un comentario.
// Es el símbolo más habitual en los lenguajes de programación.


/*
    Encerrando con los símbolos de slash y asterico
    se crea un comentario de varias
*/

/* Por ejemplo, se puede comentar porciones de código:

int numero = 5;
double decimal = 38.99;
String nombre = "Juan";
String[] animals = { "dog", "cat", "turtle" };

*/
```

**2. Comentario en Python:**

```python
# Colocando dos veces el símbolo '#' al inicio se crea un comentario.

# Para comentar varias líneas se usa 3 veces el símbolo " al inicio y al final.

"""
# Por ejemplo, se puede comentar porciones de código:

numero = 5
decimal = 38.99
animales = { "dog", "cat", "turtle" }
"""
```

