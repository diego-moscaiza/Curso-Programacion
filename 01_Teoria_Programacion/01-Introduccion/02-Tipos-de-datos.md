# Los tipos de dato

Un tipo de dato es un atributo que tienen las variables y constantes.

Antes de pasar a los tipos de datos, se tiene que conocer algo importate y es sobre la forma en que los lenguajes de programación definen la forma de declarar el tipo a las variables y constantes.

**Formas de tipado en los lenguajes de programación**

Los lenguajes de programación tienen 2 formas de tipado:

<p>
<strong>1. Tipado Estático o Estricto:</strong> El programador debe definir el tipo de dato que le pertenece a la variable.
</p>

<p>
<strong>2. Tipado Dinámico:</strong> El lenguaje de programación infiere, o mejor dicho deduce, el tipo de dato que le pertenece a la variable.
</p>

Normalmente utilizan los lenguajes de programación usan una sola forma de tipado, pero en algunos lenguajes se puede utilizar cualquiera de estas 2 formas y se tiene que revisar la documentación el cual se desea aprender para saber la forma cómo se defienen.

<br>

Ahora sí, pasemos a los tipos de datos, los cuales se dividen en 2 grupos, los primitivos y los objetos.

## 1. Primitivos

Los primitivos, también conocidos como simples, solamente almacenan un valor a la vez.
Entre los primitivos se encuentran los enteros, decimales, los caracteres y los booleanos.

**Ejemplo de tipado estático con el lenguaje Java:**

```java
// Variables de tipo numérico (int, double, decimal, etc):
int numero = 5;
double decimal = 38.99;

// Variable de tipo caractér (char):
char letra = 'A';

// Variable de tipo booleano:
boolean autorizado = true;
```

**Ejemplo de tipado dinámico con el lenguaje Python:**

```python
# Variables de tipo numérico:
numero = 5
decimal = 38.99

# Variable de tipo caractér:
letra = "A"

# Variable de tipo booleano:
autorizado = True
```

## 2. Objetos

Los objetos, también conocidos como estructurados, son todos aquellos elementos que no son de tipo primitivo, esta es su principal característica.

Estos pueden contener varios datos a la vez e inclusive estos datos pueden ser de diferentes tipos.

Los tipos de objetos que existen son:
1. Las cadenas de texto (String).
2. Estructuras de datos (arreglos, listas, diccionarios o tablas hash, pilas, colas, árboles, grafos, etc).
3. Funciones y clases existentes en los mismos lenguajes o creados por el programador.

**Ejemplo con tipado estático con el lenguaje de programación Java:**

```java
// Tipo de dato cadena (String).
String nombre = "Juan";

//  Conjunto de datos que solo contiene valores de tipo cadena.
String[] animals = { "dog", "cat", "turtle" };

// Conjunto de datos que solo contiene valores de tipo entero.
int[] numerosPrimos = { 2, 3, 5, 7, 11 };
```

**Ejemplo con tipado dinámico con el lenguaje de programación Python:**

```python
# Tipo de dato cadena.
nombre = "Juan"

# Conjunto de datos que solo contiene valores de tipo cadena.
animales = { "dog", "cat", "turtle" }

# Conjunto de datos que solo contiene valores de tipo cadena.
numerosPrimos = { 2, 3, 5, 7, 11 }
```

**Excepciones en algunos lenguajes de programación**

En el lenguaje de programación JavaScript, el tipo de dato String es considerado primitivo.
