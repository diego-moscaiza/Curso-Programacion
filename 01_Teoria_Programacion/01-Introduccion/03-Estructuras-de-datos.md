# Estructura de datos

En programación, una estructura de datos es una forma particular de organizar datos e información en la computadora para que estos sean manejados eficientemente.

Estas se guían por reglas que definen su comportamiento y la manera que se debe emplear a nivel de código.

## Categorías

Las estructuras de datos dividen en 2 categorías, estáticas y dinámicas.

<p>
<strong>1. Estáticos:</strong>

- Arreglo (unidimensal, bidimensional, multidimensional).
- Tabla hash.
</p>

<p>
<strong>2. Dinámicos:</strong>

Estos se dividen en 2 subcategorias, lineales y no lineales.

<p>
<strong>a. Lineales:</strong>

- Lista
- Pila
- Cola
- Lista enlazada
</p>

<p>
<strong>b. No lineales:</strong>

   - Árbol
   - Grafo
</p>

</p>

<br>

## Ejemplos en código

### 1. Arreglo

Un array es una variable que almacena múltiples valores en una única variable.

**Ejemplos de arreglo con el lenguaje Pyhton:**

En python se usa las listas habitualmente, pero aquí esta es la sintaxis de los arreglos.

```python
# from array import array

numeros_enteros = array("i", [3, 6, 9, 12])
numeros_decimales = array("d", [6.4, 2.2, 8.7])
numeros_flotantes = array("f", [5.72, 7.48, 0.43])
numeros_con_simbolos = array("b", [-7, +8, -10, +14])
```

**Ejemplos de arreglo con el lenguaje Java:**
```java
import java.util.Arrays;

public class Main {
  public static void main(String[] args) {

    int[] numeros = { 1, 2, 3, 4, 5 };
    String[] animals = { "dog", "cat", "turtle" };

    System.out.println(Arrays.toString(numeros));
    System.out.println(Arrays.toString(animals));
  }
}
```

### 2. Tabla hash

Una tabla hash está conformada por pares de clave y valor.

**Ejemplos de tabla hash con el lenguaje Pyhton:**

```python
jugadores = {
    10: 'Messi',
    7: 'Ronaldo'
}

paises = {
    'EC': 'Ecuador',
    'MX': 'México',
    'AR': 'Argentina'
}
```

**Ejemplos de tabla hash con el lenguaje Java:**

```java
import java.util.HashMap;

public class Main {
  public static void main(String[] args) {

    HashMap<Integer, String> jugadores = new HashMap<Integer, String>();
    jugadores.put(10, "Messi");
    jugadores.put(7, "Cristiano Ronaldo");

    System.out.println(jugadores);

    HashMap<String, String> paises = new HashMap<>();
    paises.put("EC","Ecuador");
    paises.put("MX","México");
    paises.put("AR","Argentina");

    System.out.println(paises);
  }
}

```

### 3. Lista

Una lista es una colección de elementos a los que se puede acceder por su posición en la lista.

**Ejemplos de lista con el lenguaje Pyhton:**

```python
lista_numeros = [23, 34, 675, 783]
lista_animales = ['perro,' 'gato', 'ornitorrinco']
lista_datos_mixtos = ['texto', 40, True, ['lista interna']]

print(lista_numeros[0])
print(lista_animales[2])
print(lista_datos_mixtos[3])
```

**Ejemplos de lista con el lenguaje Java:**

```java
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main {
  public static void main(String[] args) {

    List<Integer> numbers = new ArrayList<Integer>();
    numbers.add(1);
    numbers.add(2);
    numbers.add(3);

    System.out.println(numbers);

    List<Object> datosMixtos = new ArrayList<Object>();
    datosMixtos.add("texto");
    datosMixtos.add(32);
    datosMixtos.add(true);
    String[] arreglo = {"arreglo dento de una lista"};
    datosMixtos.add(Arrays.toString(arreglo));

    System.out.println(datosMixtos);
  }
}
```

### 4. Pila

Está basado en el método LIFO (Last In First Out); o en español, el último en entrar, es el primero en salir.

Un ejemplo de una pila es ver libros colocados en orden vertical, osea uno encima de otro. Para obtener el libro que está abajo de los libros apilados es necesitario mover todos los libros que están encima de él.

**Ejemplos de pila con el lenguaje Pyhton:**

```python
# Se crea una pila
pila_numeros = [1, 2, 3]

# Empujar algunos elementos a la pila
pila_numeros.append(4)
pila_numeros.append(5)

# Mostrar si la pila tiene o no contenido
if (pila_numeros.__len__ == 0):
  print(f"La pila {pila_numeros} esta vacia")
else:
  # Imprimir el tamaño de la pila
  print("Tamaño iniciañ de la pila: ", pila_numeros)

  # Imprimir el elemento superior de la pila
  print("Elemento superior de la pila: ", pila_numeros[-1])

  # Sacar un elemento de la pila
  ultimo_valor_eliminado = pila_numeros.pop()
  print("Ultimo valor de la pila eliminado: ", ultimo_valor_eliminado)

  # Imprimir el tamaño de la pila después de eliminar el ultimo elmento
  print("Pila después de eliminar el ultimo elmento: ", pila_numeros)


```

**Ejemplos de pila con el lenguaje Java:**

```java
import java.util.Stack;

public class Main {
  public static void main(String[] args) {
    // Se crea una pila
    Stack<Integer> pilaEnteros = new Stack<Integer>();

    // Insertamos elementos en la pila
    pilaEnteros.push(1);
    pilaEnteros.push(2);
    pilaEnteros.push(3);
    pilaEnteros.push(4);
    pilaEnteros.push(5);

    // Mostrar si la pila tiene o no contenido
    if (pilaEnteros.isEmpty()) {
      // Cuando la pila está vacía
      System.out.println("La pila esta vacia: " + pilaEnteros.isEmpty());
    } else {
      // Cuando la pila tiene contenido
      System.out.println("Contenido inicial de la pila: " + pilaEnteros);

      // Buscar un valor especifico
      int numeroBuscado = 1;
      System.out.println("La posición de " + numeroBuscado + " en la pila es: " + pilaEnteros.search(numeroBuscado));

      // Mostrar el ultimo valor agregado
      System.out.println("El ultimo valor de la pila es: " + pilaEnteros.peek());

      // Eliminar el ultimo valor que se insertó
      pilaEnteros.pop();

      // Mostrar la pila con el ultimo valor eliminado
      System.out.println("Pila después de retirar el último valor: " + pilaEnteros);
    }
  }
}
```

### 5. Cola

Está basado en el método FIFO (First In First Out); o en español, el primero en entrar, es el primero en salir.

Un ejemplo de una cola en la vida real es una fila de personas en una tienda o en el banco. Si llega una nueva persona, se formará al final de la fila, no al inicio y la persona situada al inicio de la fila será la primera en ser atentida y la primera en salir.

**Ejemplos de cola con el lenguaje Pyhton:**

```python
# Se crea una cola
cola_nombres = ["Maria", "Alejandro", "José", "Mario"]

# Encolando datos
cola_nombres.append("Karla")
cola_nombres.append("Flor")

if (cola_nombres.__len__ == 0):
  print(f"La cola {cola_nombres} esta vacia")
else:
  # Tamaño inicial de la cola
  print(f"Tamaño inicial de la cola: {cola_nombres}")

  # Retirando el primer valor de la cola
  print(f"Retirando a {cola_nombres.pop(0)}")

  # Retirando al nuevo primer valor de la cola
  print(f"Retirando a {cola_nombres.pop(0)}")

  # Tamaño de la cola después de retirar valores
  print(f"Tamaño de la cola después de retirar nombres: {cola_nombres}")


```

**Ejemplos de cola con el lenguaje Java:**

```java
import java.util.Queue;
import java.util.LinkedList;

public class Main {
  public static void main(String[] args) {
    Queue<Integer> colaEnteros = new LinkedList<Integer>();

    // Encolar elementos
    colaEnteros.offer(1);
    colaEnteros.offer(2);
    colaEnteros.offer(3);
    colaEnteros.offer(4);
    colaEnteros.offer(5);
    colaEnteros.offer(6);

    // Mostrar si la cola tiene o no contenido
    if (colaEnteros.isEmpty()) {
      // Cuando la cola está vacía
      System.out.println("La cola está vacía");
    } else {
      // Cuando la cola tiene contenido
      System.out.println("Contenido inicial de la pila: " + colaEnteros);

      // Mostrar el primer elemento de la cola.
      Integer primerElemento = colaEnteros.peek();
      System.out.println("Primer elemento de la cola: " + primerElemento);

      // Eliminar el primer elemento de la cola
      Integer removedElement = colaEnteros.poll();
      System.out.println("Primer elemento eliminado: " + removedElement);

      // Mostrar la cola después de la eliminación
      System.out.println("Cola después de la eliminación: " + colaEnteros);
    }
  }
}
```
