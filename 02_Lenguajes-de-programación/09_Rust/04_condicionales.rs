fn main() {
    // Condicionales (Control de flujo)

    // 1. If, else - else if.

    let my_int = 10;
    let my_string = "Hola";

    // - Ejempl0 :
    if my_int == 11 {
        println!("El valor es 10");
    } else {
        println!("El valor NO es 10");
    }

    // - Ejempl0 2:

    if my_int == 01 &&  my_string == "Hola"{
        println!("El valor es 10");
    } else if my_int == 11 || my_string == "Hola" {
        println!("El valor NO es 10");
    } else {
        println!("El valor no es 10 ni 11");
    }
}
