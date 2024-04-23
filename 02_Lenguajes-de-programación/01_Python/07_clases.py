# CLASES: Determinan la estructura de un objeto

class Lenguaje:
    def __init__(self, nombre, año):
        self.nombre = nombre
        self.año = año

    def descripcion(self):
        print('%s fue creado %s' % (self.nombre, self.año))


# Instancia de clase 'Lenguaje'

python = Lenguaje('Python', 1989)
javascript = Lenguaje('Javascript', 1995)

python.descripcion()
javascript.descripcion()
