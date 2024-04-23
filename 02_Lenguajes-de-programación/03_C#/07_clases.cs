using System;

public class Lenguaje
{
    private string nombre;
    private int anio;
    public Lenguaje(string nombre, int anio)
    {
        this.nombre = nombre;
        this.anio = anio;
    }

    public void descripcion()
    {
        Console.WriteLine("{0} fue creado en {1}", this.nombre, this.anio);
    }
}

class Program {
  public static void Main (string[] args) {

    Lenguaje html = new Lenguaje("HTML", 1993);
    html.descripcion();

    Lenguaje css = new Lenguaje("CSS", 1996);
    css.descripcion();

    Lenguaje javascript = new Lenguaje("JavaScript", 1995);
    javascript.descripcion();
  }
}
