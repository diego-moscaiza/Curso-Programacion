# FUNCIONES

# Definiendo variables.
entero = 100
animales = ['perro,' 'gato', 'ornitorrinco']

# 1. Funcion para suamr.
def sumar(primero, segundo):
    return primero + segundo

# - Llamado a la funcion y otorgar los parametros correspondientes.
resultado_suma = sumar(3, 4)
print(resultado_suma)

# 2. Funcion para multiplicar.
def multiplicar(primero, segundo):
    print(primero * segundo) #Esta función solo imprimirá

# - Llamado a la funcion y otorgar los parametros correspondientes.
multiplicar(entero, 2)# se imprimiran los valores en este caso

# 3. Funcion para multiplicar.
def imprimirPrimerElemento(arreglo):
    print(arreglo[0])

# - Llamado a la funcion y otorgar los parametros correspondientes.
imprimirPrimerElemento(animales)


# Función de ordenamiento de datos 'quicksort'.
def quicksort(arreglo):
    if len(arreglo) <= 1:
        return arreglo

    pivote = arreglo[0]
    izquierda = []
    derecha = []
    for i in range(1, len(arreglo)):
        izquierda.append(arreglo[i]) if arreglo[i] < pivote else derecha.append(arreglo[i])

    return quicksort(izquierda) + [pivote] + quicksort(derecha)

números = [23, 564, 789, 12, 65, 10]
listaOrdenada = quicksort(números)
print(listaOrdenada)


# Crear un diccionario con datos

lenguajes = {
    'nombre': 'Python',
    'año': 1989
}

# Función para imprimir valores de diccionario 'lenguajes':

def descripcion():
    print('%s fue creado %s' % (lenguajes['nombre'], lenguajes['año']))

descripcion()
