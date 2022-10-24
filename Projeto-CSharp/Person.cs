public class Person {

    private string Name { get; set; }
    private uint Age { get; set; }

    public string PersonName(string name) => this.Name = name; 

    public uint PersonAge(uint age) => this.Age = age;

    public override bool Equals(object? obj) {
        return obj is Person person &&
               Name == person.Name &&
               Age == person.Age;
    }

    public override int GetHashCode() {
        return HashCode.Combine(Name, Age);
    }
}