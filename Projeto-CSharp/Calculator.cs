class Calulator : IOperations // os métodos da interface são herdados pela classe
{
    public double Result { get; set; }
    public double firstNum;
    public double secondNum;

    public List<double> calculatorList = new List<double>(); // criação da lista para armazenar os dados inseridos pelo usuário

    public void Addition(double firstNum, double secondNum)
    {
        this.Result = firstNum + secondNum;
    }

    public void Subtraction(double firstNum, double secondNum)
    {
        this.Result = firstNum - secondNum;
    }

    public void Multiplication(double firstNum, double secondNum)
    {
        this.Result = firstNum * secondNum;
    }
    public void Division(double firstNum, double secondNum)
    {
        this.Result = firstNum / secondNum;
    }

    public void ListCaculator() // Listar todos os itens da Lista
    {

        foreach (double numbers in calculatorList)
        {
            Console.WriteLine(numbers);
        }

    }

    public void ListCount() // Contar quantos itens tem na Lista
    {

        Console.WriteLine($"EXISTEM {calculatorList.Count} NÚMEROS NA LISTA!");

    }

    public void ListGrowningNumber() // Mostrar os itens da lista em ordem crescente
    {

        calculatorList.Sort();

        foreach (double number in calculatorList)
        {
            Console.WriteLine("\t{ " + number + " }");
        }

    }

    public void ListDecreasingNumber() // Mostrar os itens da lista em ordem decrescente
    {

        calculatorList.Sort();
        calculatorList.Reverse();

        foreach (double number in calculatorList)
        {
            Console.WriteLine("\t{ " + number + " }");
        }

    }

    public void ListDuplicate() // Mostrar os itens duplicados na Lista
    {

        var numberDuplicate = calculatorList.GroupBy(x => x) // uso de LinQ com Expressão Lambda
                     .Where(g => g.Count() > 1)
                     .Select(x => new { ELEMENTO = x.Key, REPETE = x.Count() })
                     .ToList();

        Console.WriteLine(String.Join(", ", numberDuplicate));

    }

    public void ListRemoveItens() // Remover todos os itens da Lista
    {

        calculatorList.Clear();

    }

}    