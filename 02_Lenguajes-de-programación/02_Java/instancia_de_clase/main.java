package modulo;

public class Main {
    public static void main(String[] args) {
        Lenguaje html = new Lenguaje("HTML", 1993);
        html.descripcion();

        Lenguaje css = new Lenguaje("CSS", 1996);
        css.descripcion();

        Lenguaje javascript = new Lenguaje("JavaScript", 1995);
        javascript.descripcion();
    }
}

