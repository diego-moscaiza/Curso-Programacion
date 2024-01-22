# Operadores

Los lenguajes de programación otorgan un conjunto de operadores

**1. Operadores aritméticos**
<br>
**2. Operadores de asignación**
<br>
**3. Operadores de igualdad**
<br>
**4. Operadores de comparación**
<br>
**5. Operadores lógicos**
<br>
**6. Operadores a nivel de bits**
<br>

## 1. Operadores aritméticos

Los operadores aritméticos son los símbolos utilizados en la aritmética para representar operaciones matemáticas como la suma, resta, multiplicación y división. Los valores a los cuales se aplican esos operadores reciben el nombre de operandos.

**1. Operador de suma:**
```python
suma = 10 + 100
print(suma) # Salida: 110
```

**2. Operador de resta:**
```python
resta = 60 - 12
print(resta) # Salida: 48
```

**3. Operador de multiplicación:**
```python
multiplicacion = 70 * 10
print(multiplicacion) # Salida: 700
```

**4. Operador de división:**
```python
division = 90 / 5
print(division) # Salida: 18
```

**5. Operador de residuo o módulo:**

El residuo o módulo es la cantidad restante de una división.

```python
residuo = 24 % 2
print(residuo) # Salida: 12
```

**6. Operador de división entera:**

La división entera se dice cuando su resto es distinto de cero.

```python
division_entera = 90 // 7
print(suma) # Salida: 12 con resto 6 (12 y 6/7)
```

**7. Operador de exponenciación:**
```python
exponenciacion = 90 ** 3
print(exponenciacion) # Salida: 729,000
```

**8. Operador de incremento:**

Existen 2 formas de usar este operador:

- Operador de incremento a la derecha

```javascript
let x = 3
let incremento_derecha = x++
console.log(x) // Salida: 4
console.log(incremento_derecha) // Salida: 3
```

- Operador de incremento a la izquierda

```javascript
let x = 3
let incremento_izquierda = ++x
console.log(x) // Salida: 4
console.log(incremento_izquierda) // Salida: 4
```

**9. Operador de decremento:**

Existen 2 formas de usar este operador:

- Operador de decremento a la derecha

```javascript
let x = 3
let decremento_derecha = x--
console.log(x) // Salida: 2
console.log(decremento_derecha) // Salida: 3
```

- Operador de decremento a la izquierda

```javascript
let x = 3
let decremento_izquierda = --x
console.log(x) // Salida: 2
console.log(decremento_izquierda) // Salida: 2
```

**10. Operador positvo unario:**

```javascript
let x = 3
let positvo_unario = +x
console.log(x) // Salida: 3
console.log(positvo_unario) // Salida: 3
```

**11. Operador negativo unario:**
```javascript
let x = 3
let negativo_unario = -x
console.log(x) // Salida: 3
console.log(negativo_unario) // Salida: -3
```

**Jerarquía de operaciones**

Cuando se presentan operaciones aritméticas combinadas, la jerarquía determina el orden con el que deben realizarse esas operaciones. No se debe olvidar de que se siempre se resuelve de izquierda a derecha.

**1. Paréntesis:** Lo primero que se realiza en una operación es lo que está dentro de los paréntesis. Hay otros símbolos como `corchetes` y `llaves`  y su orden es: primero los paréntesis, seguido de corchetes y al final las llaves.
**2. Potencia y raíz:** Las potencias o exponenciaciones y las raíces se resuelven en segundo lugar.
**3. Multiplicación y división:** Si en la operación se encuentran los anteriores puntos, este se resuelve en tercer y penúltimo lugar.
**4. Suma y resta:** En la jerarquía se resuelven al ultimo lugar.

**Ejemplo de una operación combinada con Python:**

```python
operacion_combinada = 14 / ([3 - {4 + 9}] - 10) / 2
print(operacion_combinada) # Salida: 3.5
```

## 2. Operadores de asignación

**1. Operador de asignación simple `(=)`:**

```python
x = 10
y = x

print(y) # Salida: 10
```

**2. Operador de adición y asignación `(+=)`:**

```python
# Usando el operador:
x += 3

# Expresión equivalente:
x = x + 3
```

**3. Asignación de sustracción y asignación `(-=)`:**

```python
# Usando el operador:
x -= 3

# Expresión equivalente:
x = x - 3
```

**4. Asignación de multiplicación y asignación `(*=)`:**

```python
# Usando el operador:
x *= 3

# Expresión equivalente:
x = x * 3
```

**5. Asignación de división y asignación `(/=)`:**
```python
# Usando el operador:
x /= 3

# Expresión equivalente:
x = x / 3
```

**6. Asignación de módulo y asignación `(%=)`:**
```python
# Usando el operador:
x %= 3

# Expresión equivalente:
x = x % 3
```

## 3. Operadores de igualdad

Los operadores de comparación también conocidos como operadores relacionales, comparan sus operandos. Se utilizan para comparar o evaluar la relación entre diferentes valores.

**1. Operador de igualdad**

Compara si el valor y el tipo de dato son equivalentes. Se usa los símbolos `==`.

**Ejemplo:**

```python
print(4 == 4) # Salida: True.
print(4 == '4') # Salida: False. Da este resultado porque compara un número con un texto.
```

**2. Operador de no igualdad**

Compara si el valor y el tipo de dato no son equivalentes. Se usa los símbolos `!=`.

**Ejemplo:**

```python
print(4 != 4) # Salida: False.
print(4 != 5) # Salida: True.
```

## 4. Operadores de comparación

**1. Operador menor `<`**

```python
es_menor = 4 < 5
print(es_menor) # Salida: True.
```

**2. Operador mayor `>`**

```python
es_mayor = 4 > 5
print(es_mayor) # Salida: False.
```

**3. Operador menor o igual `<=`**

```python
es_menor_igual = 4 <= 5
print(es_menor_igual) # Salida: False.
```

**4. Operador mayor o igual `>=`**

```python
es_mayor_igual = 4 >= 5
print(es_mayor_igual) # Salida: True.
```

## 5. Operadores lógicos

Los operadores lógicos o booleanos, tiene como base la `lógica proposicional` o lógica de enunciados y las `tablas de verdad`. La lógica proposicional es un sistema formal simple dentro de la lógica matemática que se representa mediante `proposiciones` que poseen valores booleanos los cuales pueden ser verdaderos o falsos y los `conectores lógicos` que tiene como base las funciones de verdad las cuales toma como argumentos los valores booleanos. Las tablas de verdad se conforman de proposiciones y conectores y dependiendo del tipo de conector y los valores de las proposiciones obtendremos un resultado booleano.

Para poder utilizar los operadores lógicos dependerá del lenguaje de programación ya que normalmente hace el uso de símbolos y otros de palabras reservadas. En la teoría, estos símbolos o palabras reservadas se representan como los conectores de las tablas de verdad.


Los tipos de operadores lógicos son:
**1. Operador de conjunción**
<br>
**2. Operador de disyunción**
<br>
**3. Operador de negación**
<br>

**1. Operador de conjunción**

Se utiliza para comparar si las dos proposiciones o valores se cumplen, mejor dicho si son verdaderas, devuelva `True` como resultado, y si una de las dos o ambas resultan ser falsa nos devuelve como resultado `False`.

Para usar la funcionalidad del operador se puede usar la palabra reservada `and` o los símbolos `&&`.

**Ejemplos:**

Usando Python:

```python
a = 5
b = -1
resultado = (a > b) and (b < 0)
print(resultado) # Salida: True
```

```python
verdadero = True
falso = False

print(verdadero and verdadero) # Salida: True
print(verdadero and falso) # Salida: False
print(False and True) # Salida: False
print(False and False) # Salida: False
```

Usando Java:

```java
int a = 5;
int b = -1;
boolean resultado = (a > b) && (b < 0);

System.out.println(resultado); // Salida: true
```

```java
boolean verdadero = true;
boolean tambienVerdadero = true;
boolean falso = false;
boolean tambienFalso = false;

System.out.println(verdadero && tambienVerdadero); // Salida: true
System.out.println(verdadero && falso); // Salida: false
System.out.println(falso && verdadero); // Salida: false
System.out.println(falso && tambienFalso); // Salida: false
```

**2. Operador de disyunción**

Se utiliza para comparar si las dos o una de las dos proposiciones o valores se cumplen, devuelva `True` como resultado, y si ambas resultan ser falsa nos devuelve como resultado `False`.

Para usar la funcionalidad del operador se puede usar la palabra reservada `or` o los símbolos `||`.

**Ejemplos:**

Usando Python:

```python
a = 5
b = -1
resultado = (a > b) or (b < 0)
print(resultado) # Salida: True
```

```python
verdadero = True
falso = False

print(verdadero or verdadero) # Salida: True
print(verdadero or falso) # Salida: True
print(False or True) # Salida: True
print(False or False) # False
```

Usando Java:

```java
boolean verdadero = true;
boolean tambienVerdadero = true;
boolean falso = false;
boolean tambienFalso = false;

System.out.println(verdadero || tambienVerdadero); // Salida: true
System.out.println(verdadero || falso); // Salida: true
System.out.println(falso || verdadero); // Salida: true
System.out.println(falso || tambienFalso); // Salida: false
```

**3. Operador de negación**

Se utiliza para negar una proposición o valor.

Para usar la funcionalidad del operador se puede usar la palabra reservada `not` o el símbolo `!`.

**Ejemplos:**

Usando Python:

```python
a = 5
b = -1
resultado = (a > b)
resultado1 = (a > b) && (b < 0)

print(not resultado) # Salida: False
print(not resultado1) # Salida: True
```

```python
verdadero = True
falso = False

print(not verdadero) # Salida: False
print(not falso) # Salida: True
```

Usando Java:

```java
int a = 5;
int b = -1;
boolean resultado = (a > b);
boolean resultado1 = (a > b) && (b < 0);

System.out.println(!resultado); // Salida: false
System.out.println(!resultado1); // Salida: true
```

```java
boolean verdadero = true;
boolean falso = false;

System.out.println(!verdadero); // Salida: false
System.out.println(!falso); // Salida: true
```

## 6. Operadores a nivel de bits

**1. Operadores bit a bit:**
Ejecutan las operaciones lógicas AND, OR, XOR, NOT, etc., sobre los bits individuales de los operandos. Nos basamos en la misma teoría que los operadores lógicos y además tomamos los valores a en base 2 y no en base 10.

**Operador AND a nivel de bits `(&)`:**

```javascript
let numero1 = 7; // En base 2 es: 111
let numero2 = 6; // En base 2 es: 110
let resultado = numero1 & numero2;

console.log(resultado); // Salida: 6. En base 2 es: 110
```

**Operador OR a nivel de bits `(|)`:**

```javascript
let numero1 = 7; // En base 2 es: 111
let numero2 = 6; // En base 2 es: 110
let resultado = numero1 | numero2;

console.log(resultado); // Salida: 7. En base 2 es: 111
```

**Operador XOR u OR exclusivo a nivel de bits `(^)`:**

```javascript
let numero1 = 7; // En base 2 es: 111
let numero2 = 6; // En base 2 es: 110
let resultado = numero1 ^ numero2;

console.log(resultado); // Salida: 1. En base 2 es: 0001
```

**Operador Complemento a nivel de bits `(~)`:**

```javascript
let numero = 7; // En base 2 es: 111
let resultado = ~numero;

console.log(resultado); // Salida: -8. En base 2 es: -1000
```

**2. Operadores de desplazamiento de bits:**

Los operadores de desplazamiento de bits sirven para poder desplazar los bits de un numero hacia un lado, reduciendo o incrementado su valor.

**Desplazamiento hacia la derecha `(>>)`:**

Con este operador, los bits son desplazados hacia la derecha a partir del último bit y son descartados hasta cumplir con la cantidad de bits que se debe desplazar.

```javascript
let numero1 = 12; // En base 2 es: 1100
let numero2 = 2; // En base 2 es: 0010

let resultado = numero1 >> numero2;

console.log(resultado); // Salida: 3. En base 2 es: 0011
```

**Desplazamiento hacia la izquierda `(<<)`:**

Con este operador, los bits son desplazados hacia la izquierda a partir del último bit hasta cumplir con los bits que se deben desplazar y los bits que se agregan son de valor 0.

```javascript
let numero1 = 12; // En base 2 es: 1100
let numero2 = 2; // En base 2 es: 0010

let resultado = numero1 << numero2;

console.log(resultado); // Salida: 48. En base 2 es: 110000
```

