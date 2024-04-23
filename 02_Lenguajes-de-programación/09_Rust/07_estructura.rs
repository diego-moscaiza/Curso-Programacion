// Estructuras. Funciona como clases

struct MyStruct {
    name : String,
    age: i32,
}

impl MyStruct {
    fn new(name : &str, age: i32,) -> MyStruct{
        MyStruct {
            name :String::from(name),
            age
            }
    }
}

fn main() {

    // Instaciando una estructura
    let my_struct = MyStruct:: new("Diego", 23);
    println!("Mi nombre es {} y tengo {} años.", my_struct.name, my_struct.age);

}
