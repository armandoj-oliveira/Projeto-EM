using System.Collections;

public class Person {

    private string Name { get; set; }
    private uint Age { get; set; }

    public string PersonName(string name) => Name = name; 

    public uint PersonAge(uint age) => Age = age;

}