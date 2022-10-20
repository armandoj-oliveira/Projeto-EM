class Calulator : IOperations // os métodos da interface são herdados pela classe
{
    public double Result { get; set; }
    public double firstNum;
    public double secondNum;

    public List<double> calculatorList = new List<double>(); // criação da lista para armazenar os dados inseridos pelo usuário

    public void Addition(double firstNum, double secondNum) => this.Result = firstNum + secondNum;

    public void Subtraction(double firstNum, double secondNum) => this.Result = firstNum + secondNum;

    public void Multiplication(double firstNum, double secondNum) => this.Result = firstNum * secondNum;

    public void Division(double firstNum, double secondNum) => this.Result = firstNum / secondNum;

    //------------------------- Imprimir Números da Lista ---------------------------------------

    public void ListCaculator()
    {

        if (calculatorList.Count == 0)
        {

            Console.WriteLine("NÃO EXISTE NENHUM NÚMERO NA LISTA!");

        }
        else
        {

            Console.WriteLine($"\nOS NÚMEROS INSERIDOS NO SISTEMA SÂO: ");

            foreach (double numbers in calculatorList)
            {
                Console.WriteLine(numbers);
            }

        }
    }

    //------------------------- Imprimir a quantidade de Números na Lista ---------------------------------------
    public void ListCount() 
    {

        Console.WriteLine($"EXISTEM {calculatorList.Count} NÚMEROS NA LISTA!");

    }

    //------------------------- Imprimir em ordem crescente a Lista ---------------------------------------
    public void ListGrowningNumber()
    {

        if (calculatorList.Count == 0)
        {

            Console.WriteLine("NÃO EXISTE NENHUM NÚMERO NA LISTA!");

        }
        else
        {

            calculatorList.Sort();

            Console.WriteLine("\nA ORDEM CRESCENTE DA LISTA DE NÚMEROS É: ");

            foreach (double number in calculatorList)
            {
                Console.WriteLine("\t{ " + number + " }");
            }

        }
    }

    //------------------------- Imprimir em ordem decrescente a Lista ---------------------------------------
    public void ListDecreasingNumber() 
    {

        if (calculatorList.Count == 0)
        {

            Console.WriteLine("NÃO EXISTE NENHUM NÚMERO NA LISTA!");

        }
        else
        {
            calculatorList.Sort();
            calculatorList.Reverse();

            Console.WriteLine("\n A ORDEM DECRESCENTE DA LISTA DE NÚMEROS É: ");

            foreach (double number in calculatorList)
            {
                Console.WriteLine("\t{ " + number + " }");
            }
        }

    }

    //------------------------- Imprimir Itens Duplicado na Lista ---------------------------------------
    public void ListDuplicate()
    {

        if (calculatorList.Count == 0)
        {

            Console.WriteLine("NÃO EXISTE NENHUM NÚMERO NA LISTA!");

        }
        else
        {

            var numberDuplicate = calculatorList.GroupBy(x => x) // uso de LinQ com Expressão Lambda
                         .Where(g => g.Count() > 1)
                         .Select(x => new {ELEMENTO = x.Key, REPETE = x.Count() })
                         .ToList();

            Console.WriteLine(String.Join(", ", numberDuplicate));

        }
    }

    //------------------------- Remoção do Itens da Lista ---------------------------------------
    public void ListRemoveItens() 
    {

        calculatorList.Clear();


        Console.WriteLine("LISTA ESVAZIDA COM SUCESSO!");

    }

}    