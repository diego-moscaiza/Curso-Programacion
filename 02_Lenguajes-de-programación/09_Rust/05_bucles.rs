use std::collections::HashSet;
use std::collections::HashMap;

fn main() {

    // - Bucles

    let my_list: Vec<&str> = vec!["Brais", "Diego", "mail.com", "36"];
    let my_set : HashSet<&str> = vec!["Brais", "Diego", "mail.com", "36"]
      .into_iter()
      .collect();
    let my_map : HashMap<&str, i32> = vec![("Brais", 36), ("Diego", 23)]
      .into_iter()
      .collect();

    // 1. For
    for value in &my_list {
        println!("{}", value);
    }

    for value in &my_set {
        println!("{}", value);
    }

    for (key, value) in &my_map {
        println!("{} {}", key, value);
    }

    // 2. While

    let mut my_counter = 0;
    while my_counter < my_list.len() {
        println!("{}", my_list[my_counter]);
        my_counter += 1;
    }
}
