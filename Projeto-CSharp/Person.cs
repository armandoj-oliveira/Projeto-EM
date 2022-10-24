using System.Collections;

public class Person {

    private string Name { get; set; }
    private uint Age { get; set; }

    public Hashtable personValidation = new Hashtable();

    public string PersonName(string name) => this.Name = name; 

    public uint PersonAge(uint age) => this.Age = age;

    //public void Adicionar(string name, uint age) {

    //    personValidation[name] = age;

    //}

    //public void Imprimir() {

    //    foreach(DictionaryEntry persons in personValidation) {
        
    //        string name = (string)persons.Key;
    //        uint age = (uint)persons.Value;
    //        Console.WriteLine($"Nome: {name}, Idade: {age}");

    //    }

    //}

    //public void Verificar(string name) {

    //    if (Name == name) {

    //        Console.WriteLine("JÁ CADASTRADO!");

    //    } else {

    //        Console.WriteLine("Pode continuar!");

    //    }


    //}
}