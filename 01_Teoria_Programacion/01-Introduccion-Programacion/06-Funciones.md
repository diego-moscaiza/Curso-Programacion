# Funciones

En programación, una función es una secuencia de sentencias que realizan una operación y que reciben un nombre. Cuando se define una función, se especifica el nombre y la secuencia de sentencias. Más adelante, se puede llamar o invocar a la función por su nombre.

**Ejemplos:**

Usando el lenguaje Python:

```python
def Funcion():
	print("Soy una función")
```

Usando el lenguaje Java:

```java
void Funcion() {
    System.out.println("Soy una función");
}
```

## 1. Parámetros

Son variables que se definen al declarar funciones, las cuales van dentro de los paréntesis de la función. Los parámetros son utilizados para enviar valores al hacer un llamado a la función.

Se crea una función llamada `sumar()`.

Usando el lenguaje Python:

```python
def sumar(primero, segundo):
    return primero + segundo
```

Usando el lenguaje Java:

```java
Integer sumar(Integer primero, Integer segundo) {
    return primero + segundo;
}
```

## 2. Argumentos

Son los valores que van a tomar cada uno de los parámetros que se han definido en las funciones.

Ahora se llamará a la función `sumar()` y otorgar los argumentos correspondientes.

Usando el lenguaje Python:

```python
# Asignamos una variable al método.
resultado_suma = sumar(3, 4)

print(resultado_suma) # Salida: 7
```

Usando el lenguaje Java:

```java
public void usoFuncionSumar() {
    // Asignamos una variable al método.
    Integer resultado = sumar(3, 4);

    System.out.println(resultado); // Salida: 7
}
```
