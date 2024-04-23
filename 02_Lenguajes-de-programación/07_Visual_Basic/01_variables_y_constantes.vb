Module 1_introduccion
    '''' Al incio del codigo de cada modulo de Visual Basic debe ir la palabra Module con el nombre del archivo.'

    '''' El procedimiento Sub realiza una tarea y luego devuelve el control al código de llamada, pero no devuelve un valor al código de llamada. Puede tomar argumentos, como constantes, variables o expresiones que se pasan por un procedimiento de llamada.'

    '''' Visual Basic no es "Case Sensitive" por lo que las variables con nombres iguales pero con letras en mayuscula se detectarán como iguales.

    Sub Main()
        ' Todos los atributos se les puede definir el nivel de acceso como: Public, Private, Protected, Friend y otras.

        ' 1.- Variables

        ' - Textos

        Dim letra As Char = "z"

        Dim texto As String
        texto = "Hola Mundo" ' Esta es o tra forma de definir variables

        ' - Números

        Dim numero As Integer
        numero = 12
        numero = 5 ' Cambiando el valor de la variable

        Dim centimetros As Double = 23.76

        ' - Booleanos
        Dim verdadero As True
        Dim falso As False

        ' 2.- Constantes
        Const pulgadas As Double = 12.5
        'pulgadas = 15.6 ' Se muestra un error al intentar cambair el valor de una constante.


        ' Imprimir datos
        Console.WriteLine(texto)

        ' Con la funcion ReadKey() podemos definir que el proceso termine cuando se pulse alguna tecla.'
        Console.ReadKey(True)
    End Sub


    '''' Alcance de las variables.

    ' 1. Variable Global: Estas tipo de variables se declara fuera de una función y se puede acceder a ella en cualquier función dentro del modulo.

    ' 2. Variable local. No se puede acceder desde otro proceso

    ' - Declarando una variable global:
    Dim numeroGlobal As Integer = 400

    Sub OtroMetodo()
        ' - Declarando una variable local:
        Dim numeroLocal As Integer = 400
    End Sub


    Sub OtroMetodoMas()
        numeroGlobal ' - Llamando a una variable global
    End Sub

End Module
