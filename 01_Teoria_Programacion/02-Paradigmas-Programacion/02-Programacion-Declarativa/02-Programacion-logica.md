# 2. Programación lógica

La lógica, por definición es la ciencia que estudia la estructura o formas del pensamiento humano. Como las proposiciones, conceptos y razonamiento. Sirve para establecer leyes y principio válidos para obtener un criterio de verdad.

La programación lógica es un paradigma que se basa en la `lógica de primer orden` también llamada lógica o cálculo de predicados la cual representa todo como la relación entre un `sujeto` y una **afirmación** acerca de este, que viene a ser un `predicado`. La lógica de predicados permite la distinción entre sujetos y predicados que no era posible con la `lógica de proposiciones`.

Cabe recalcar que la lógica de predicados y la lógica de proposiciones surgen de la `lógica matemática` o lógica formal, con el fin de estudiar la inferencia o deducción, o sea que se encarga de crear conclusiones a partir de proposiciones o ideas formuladas o que se pueden presuponer.

Este paradigma se caracteriza por la formulación de enunciados que deben ser descritos por un usuario teniendo en cuenta la coherencia de cada enunciado, por ejemplo: **"Marte es un planeta"** o **"Un árbol es un planta"**. A partir de los enunciados se crea una colección de `hechos` y `reglas`. A su vez estos dos se denominan como `cláusulas definidas`.

La estructura de los hechos y las reglas o relaciones son las siguientes: Un hecho es una regla que sólo tiene una cabeza con cuerpo vacío, en cambio una regla tiene una cabeza con su cuerpo definido.

Para desarrollar un programa utilizando la programación lógica, este debe constar de dos aspectos: Primero, `la lógica` o razonamiento que debe usar el desarrollador para definir los hechos y reglas para representar criterios coherentes; y segundo: `el control` como la deducción lógica para dar respuestas.

Los programas lógicos suelen usarse para la inferencia de la información; por ejemplo: para simular el razonamiento de la inteligencia artificial, ya que debe interpretar la información otorgada para dar una respuesta.

Las características que definen a la programación lógica son los siguientes:

## 1. Variables lógicas

Las variables lógicas son valores que se definen para representar la información en forma de un hecho. Estas variables pueden actuar como variables de entrada y de salida.

**Ejemplo:**

Usaremos el lenguaje `Prolog` para los ejemplos.

Tomaremos en cuenta las afirmaciones: `Spike es un perro` , `Tom es un gato` y `Jerry es un ratón`.

```prolog
% Entrada o inserción de datos.

% Definición de hechos:
% Los hechos son solo cabezas sin cuerpo.

es_perro('spike').
es_gato('tom').
es_raton('jerry').

% Consultas: Sirven para comprobar la información:

es_gato('tom'). % Salida: true.
% El resultado es "true" porque el hecho sí está declarado.

es_perro('blacky'). % Salida: false.
% El resultado es "false" por que no se ha declarado como un hecho, por lo tanto, el programa no lo puede inferir.
```

## 2. Inversibilidad

La inversibilidad significa que los argumentos del hecho pueden como entrada y salida. Es decir, no es necesario pasar una variable con un nombre definido, sino que se también se puede pasar una un valor como `x` o `y`.

En este caso usaremos la afirmación `Paco es el padre de Pepe`.

**Ejemplo:**

```prolog
% Definición de hechos:
es_padre_de('paco', 'pepe').
% Paco como primer parametro ya que es el padre y Pepe como segundo por que es el hijo.

% Definición de reglas:
% Las reglas con cabezas con cuerpos.
es_hijo_de(X, Y) :- es_padre_de(Y, X).

% Consultas:
es_padre_de('paco', X). % Salida: X = pepe.
es_padre_de(X, 'pepe'). % Salida: X = paco.
```

## 3. Resolución SDL
La resolución SDL (Selective Linear Definite clause resolution) que significa `resolución selectiva de cláusula definida lineal` es el mecanismo de inferencia que utiliza la programación lógica. Consiste en crear un árbol de búsqueda que explora todas las posibles respuestas.

El mecanismo conocico como `backtracking` permite que se devuelva múltiples soluciones cuando se invoca un predicado. Entrega un solución por cada rama de éxito en el árbol de resolución SLD.

**Ejemplo:**

```prolog
hombre('Bryan').
hombre('Jose').
mujer('Ana').
mujer('Luz').

pareja(M,H):-mujer(M),hombre(H).

gusto('Ana', 'Cine').
gusto('Luz', 'Teatro').
gusto('Bryan', 'Futbol').
gusto('Jose', 'Cine').

novios(M,H):-pareja(M, H),gusto(H,G),gusto(M,G).

% Consultas:
novios(M,H).
% M = 'Ana',
% H = 'Jose' .
```

## 4. Recursividad

Las reglas tiene la propiedad de llamarse a si mismas, se les conoce como reglas recursivas.

```prolog
mas_grande('elefante','caballo').
mas_grande('caballo','perro').
mas_grande('perro','ratón').
mas_grande('ratón','hormiga').

% Regla de predicado de parada: Se le llama así porque detiene al predicado cuando la regla se cumple.
mucho_mas_grande(A,B):-mas_grande(A,B).

% Regla recursiva: Hace el uso de la regla de predicado de parada.
mucho_mas_grande(A,B):-mas_grande(A,X),mucho_mas_grande(X,B).

% Consultas:
mucho_mas_grande(elefante, caballo).  % Salida: true.
mucho_mas_grande(elefante, perro).    % Salida: true.
mucho_mas_grande(elefante, ratón).    % Salida: true.
mucho_mas_grande(elefante, hormiga).  % Salida: true.
```
