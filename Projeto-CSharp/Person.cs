class Person
{
    private String Name { get; set; }
    private int Age { get; set; }

    public String PersonName(string name)
    {

        return this.Name = name;

    }

    public int PersonAge(int age)
    {

        return this.Age = age;

    }

}