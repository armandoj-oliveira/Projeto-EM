class Person {
    private String Name { get; set; }
    private short Age { get; set; }

    public String PersonName(string name) => this.Name = name;

    public int PersonAge(short age) => this.Age = age;

}