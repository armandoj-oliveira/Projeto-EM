class Person {
    private string Name { get; set; }
    private int Age { get; set; }

    public string PersonName(string name) => this.Name = name; 

    public int PersonAge(int age) => this.Age = age; 

}