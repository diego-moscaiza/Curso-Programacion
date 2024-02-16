# Tipos de datos

En programación, un dato es un valor que tiene un tipo de dato. Existen varios tipos de datos y se conocen 2 grupos, los primitivos y los objetos. Todo tipo de dato que no es primitivo es un tipo de objeto.

Los lenguajes de programación tienen dos formas de tipado:

**1. Tipado Estricto:** El programador debe de definir el tipo de dato de cada valor.
<br>
**2. Tipado Dinámico:** El lenguaje infiere el tipo de dato del valor.

## 1. Primitivos

Los primitivos, también conocidos como simples, entre los primitivos se encuentran los enteros, decimales, los caracteres y los booleanos.

**Ejemplo con tipado estricto con el lenguaje Java:**

```java
// Datos de tipo numérico:
int numero = 5;
double decimal = 38.99;

// Datos de tipo caractér:
char letra = 'A';

// Datos de tipo booleano:
boolean autorizado = true;
```

**Ejemplo con tipado dinámico con el lenguaje Python:**

```python
# Datos de tipo numérico:
numero = 5
decimal = 38.99

# Datos de tipo caractér:
letra = "A"

# Datos de tipo booleano:
autorizado = True
```

## 2. Objetos

Los objetos conocidos como estructurados son todo aquellos que no es de tipo primitivo y se crean a partir de funciones y clases, estos pueden contener varios datos a la vez, entre estos están las cadenas de texto, las arreglos, listas y diccionarios, funciones y clases.

**Ejemplo con tipado estricto con el lenguaje Java:**

```java
// Tipo de dato cadena.
String nombre = "Juan";

//  Conjunto de datos que solo contiene valores de tipo cadena.
String[] animals = { "dog", "cat", "turtle" };

//  Conjunto de datos que solo contiene valores de tipo cadena.
int[] numerosPrimos = { 2, 3, 5, 7, 11 };
```


**Ejemplo con tipado dinámico con el lenguaje Python:**

```python
# Tipo de dato cadena.
nombre = "Juan"

# Conjunto de datos que solo contiene valores de tipo cadena.
animales = { "dog", "cat", "turtle" }

# Conjunto de datos que solo contiene valores de tipo cadena.
numerosPrimos = { 2, 3, 5, 7, 11 }
```

## Comentarios.

En los lenguajes de programación se puede realizar comentarios al código para dejar una descripción o un mensaje breve. Se puede comentar el mismo código con el propósito de que no se ejecute esa porción de código. Algunos lenguajes de programación manejan una misma forma de crear comentarios y en otros puede variar.

**Ejemplos:**

**1. Comentarios en Java:**

```java
// Se usa el símbolo '//' al inicio. Es el símbolo más habitual en los lenguajes de programación

// /* Comentario de varias líneas usando '/* ... */ encerrando el contenido'

/*

int numero = 5;
double decimal = 38.99;
String nombre = "Juan";
String[] animals = { "dog", "cat", "turtle" };

*/
```

**2. Comentario en Python:**

```python
# Se usa el símbolo '#' al inicio.

# Comentario e varias líneas usando """ ... """ encerrando el contenido.

"""
numero = 5
decimal = 38.99
animales = { "dog", "cat", "turtle" }
"""
```
