using System.Text.RegularExpressions;

class MainProgram
{

    public delegate void MenuSystem();

    static void Main(string[] args)
    {

        //-------------------------- Criação de Objetos --------------------------------------
        
        Calulator calculator = new Calulator();
        Person person = new Person();
        PrintOut print = new PrintOut();


        //-------------------------- Criação de Delegates --------------------------------------

        MenuSystem menuResgisterUser = new MenuSystem(print.PrintRegistrationPerson);
        MenuSystem checkName = new MenuSystem(print.printCheckNameError);
        MenuSystem checkAge = new MenuSystem(print.printCheckAgeError);
        MenuSystem menuSystem = new MenuSystem(print.PrintInitialMenu);
        MenuSystem menuCalculator = new MenuSystem(print.PrintMenuCalculator);
        MenuSystem menuList = new MenuSystem(print.PrintMenuList);
        MenuSystem messageLater = new MenuSystem(print.PrintMessageLater);
        MenuSystem messageError = new MenuSystem(print.PrintMessageError);

        //----------------------------------------------------------------

        menuResgisterUser(); // Mensagem de Resgistro da Pessoa

        Console.Write("\nINFORME SEU NOME: ");

        String name = Console.ReadLine();
        person.namePerson = name;

        if (!Regex.IsMatch(name, @"^[a-zA-Z]+$")) // Indica se a expressão regular encontra uma correspondência na cadeia de caracteres de entrada.
        {                                         // Caso essa afirmativa seja verdadeira

            checkName(); // Imprime Mensagem de Erro - Nome Inválido

        }
        else // Caso a afirmativa for falsa, o algoritmo continua
        {

            Console.Write("\nINFORME SUA IDADE: ");

            int age = Convert.ToInt32(Console.ReadLine());
            person.agePerson = age;

            if (age < 1 || age > 110) // Verificar a Idade do Usuário é menor que 0 ou maior que 100
            {                         // Caso essa afirmativa seja verdadeira

                checkAge(); // Imprime Mensagem de Erro - Idade Inválida

            }
            else   // Caso a afirmativa for falsa, o algoritmo continua
            {

                int i = 1;

                //---------------------- Laço de Repetição: Menu Sistema --------------------------------------

                while (i != 0)
                {

                    menuSystem();
                    int choiceMenu = Convert.ToInt32(Console.ReadLine());

                    if (choiceMenu == 0)
                    {

                        messageLater(); // Mensagem de Despedida
                        break;

                    }
                    else if (choiceMenu == 1)
                    {

                        print.PrintDataPerson(person); // Mensagem de Dados do Usuário

                    }
                    else if (choiceMenu == 2)
                    {

                        menuCalculator();
                        int choiceCalculatorOperations = Convert.ToInt32(Console.ReadLine()); 

                        int j = 1;

                        //---------------------- Laço de Repetição: Menu Calculadora --------------------------------------

                        while (j != 0)
                        {
                            if (choiceCalculatorOperations == 0)
                            {

                                break; // Voltar para o Menu do Sistema

                            }
                            else if (choiceCalculatorOperations == 1)
                            {
                                //------------------------- Método de Adição ---------------------------------------

                                Console.Write("\nINFORME O PRIMEIRO NÚMERO: ");
                                double firstValueNumber = Convert.ToDouble(Console.ReadLine()); // Converter String para Double

                                Console.Write("\nINFORME O SEGUNDO NÚMERO: ");
                                double secondValueNumber = Convert.ToDouble(Console.ReadLine()); // Converter String para Double

                                calculator.Addition(firstValueNumber, secondValueNumber); // Método para Adição

                                Console.WriteLine($"\nA ADIÇÃO ENTRE OS NÚMEROS {firstValueNumber} E {secondValueNumber} É IGUAL A: {calculator.Result}");

                                calculator.calculatorList.Add(firstValueNumber); // Inserir o Valor na Lista
                                calculator.calculatorList.Add(secondValueNumber); // Inserir o Valor na Lista

                                Console.WriteLine("\n DESEJA CONTINUAR? ");
                                Console.WriteLine("\t1 - SIM\t\t2 - NÃO");

                                int choiceContinue = Convert.ToInt32(Console.ReadLine()); // Inserir o Valor na Lista

                                if (choiceContinue == 1)
                                {

                                    continue;

                                }
                                else if (choiceContinue == 2)
                                {

                                    break;

                                }
                                else
                                {

                                    messageError(); // Mensagem de Erro - Opção Inválida

                                    break;

                                }
                                //------------------------- Fim do Método de Adição ---------------------------------------

                            }
                            else if (choiceCalculatorOperations == 2)
                            {
                                //------------------------- Método de Subtração ---------------------------------------

                                Console.Write("\nINFORME O PRIMEIRO NÚMERO: ");
                                double firstValueNumber = Convert.ToDouble(Console.ReadLine()); 

                                Console.Write("\nINFORME O SEGUNDO NÚMERO: ");
                                double secondValueNumber = Convert.ToDouble(Console.ReadLine()); 

                                calculator.Subtraction(firstValueNumber, secondValueNumber); 

                                Console.WriteLine($"\nA SUBTRAÇÃO ENTRE OS NÚMEROS {firstValueNumber} E {secondValueNumber} É IGUAL A: {calculator.Result}");

                                calculator.calculatorList.Add(firstValueNumber); 
                                calculator.calculatorList.Add(secondValueNumber); 

                                Console.WriteLine("\n DESEJA CONTINUAR? ");
                                Console.WriteLine("\t1 - SIM\t\t2 - NÃO");

                                int choiceContinue = Convert.ToInt32(Console.ReadLine()); 

                                if (choiceContinue == 1)
                                {

                                    continue;

                                }
                                else if (choiceContinue == 2)
                                {

                                    break;

                                }
                                else
                                {

                                    messageError(); // Mensagem de Erro - Opção Inválida

                                    break;

                                }
                                //------------------------- Fim do Método de Subtração ---------------------------------------

                            }
                            else if (choiceCalculatorOperations == 3)
                            {
                                //------------------------- Método de Multiplicação ---------------------------------------

                                Console.Write("\nINFORME O PRIMEIRO NÚMERO: ");
                                double firstValueNumber = Convert.ToDouble(Console.ReadLine()); 

                                Console.Write("\nINFORME O SEGUNDO NÚMERO: ");
                                double secondValueNumber = Convert.ToDouble(Console.ReadLine()); 

                                calculator.Multiplication(firstValueNumber, secondValueNumber); 

                                Console.WriteLine($"\nA MULTIPLICAÇÃO ENTRE OS NÚMEROS {firstValueNumber} E {secondValueNumber} É IGUAL A: {calculator.Result}");

                                calculator.calculatorList.Add(firstValueNumber); 
                                calculator.calculatorList.Add(secondValueNumber); 

                                Console.WriteLine("\n DESEJA CONTINUAR? ");
                                Console.WriteLine("\t1 - SIM\t\t2 - NÃO");

                                int choiceContinue = Convert.ToInt32(Console.ReadLine()); 

                                if (choiceContinue == 1)
                                {

                                    continue;

                                }
                                else if (choiceContinue == 2)
                                {

                                    break;

                                }
                                else
                                {

                                    messageError(); // Mensagem de Erro - Opção Inválida

                                    break;

                                }
                                //------------------------- Fim do Método de Multiplicação ---------------------------------------

                            }
                            else if (choiceCalculatorOperations == 4)
                            {
                                //------------------------- Método de Divisão ---------------------------------------

                                Console.Write("\nINFORME O PRIMEIRO NÚMERO: ");
                                double firstValueNumber = Convert.ToDouble(Console.ReadLine());

                                Console.Write("\nINFORME O SEGUNDO NÚMERO: ");
                                double secondValueNumber = Convert.ToDouble(Console.ReadLine());

                                calculator.Division(firstValueNumber, secondValueNumber);

                                Console.WriteLine($"\nA DIVISÃO ENTRE OS NÚMEROS {firstValueNumber} E {secondValueNumber} É IGUAL A: {calculator.Result}");

                                calculator.calculatorList.Add(firstValueNumber); 
                                calculator.calculatorList.Add(secondValueNumber); 

                                Console.WriteLine("\n DESEJA CONTINUAR? ");
                                Console.WriteLine("\t1 - SIM\t\t2 - NÃO");

                                int choiceContinue = Convert.ToInt32(Console.ReadLine());

                                if (choiceContinue == 1)
                                {

                                    continue;

                                }
                                else if (choiceContinue == 2)
                                {

                                    break;

                                }
                                else
                                {

                                    messageError(); // Mensagem de Erro - Opção Inválida

                                    break;

                                }
                                //------------------------- Fim do Método de Adição ---------------------------------------

                            }
                            else
                            {

                                messageError(); // Mensagem de Erro - Opção Inválida

                                break;

                            }
                        }
                        //---------------------- Fim do Laço de Repetição: Menu Calculadora ----------------------------------

                    }
                    else if (choiceMenu == 3)
                    {

                        menuList();
                        int choiceList = Convert.ToInt32(Console.ReadLine()); 

                        int k = 1;

                        //---------------------- Laço de Repetição: Menu Lista --------------------------------------
                        
                        while (k != 0)
                        {

                            if (choiceList == 0)
                            {

                                break;

                            }
                            else if (choiceList == 1)
                            {

                                calculator.ListCaculator(); // Verifica se tem itens na Lista. 
                                                            // Se não tiver nada na Lista, imprime a mensagem que não contém nada
                                                            // Se tiver algo na Lista, imprime na tela os valores
                                break;

                            }
                            else if (choiceList == 2)
                            {

                                calculator.ListCount(); // Contar quantos itens tem na Lista

                                break;

                            }
                            else if (choiceList == 3)
                            {


                                calculator.ListGrowningNumber(); // Mostrar os itens da lista em ordem crescente

                                break;

                            }
                            else if (choiceList == 4)
                            {


                                calculator.ListDecreasingNumber(); // Mostrar os itens da lista em ordem decrescente

                                break;


                            }
                            else if (choiceList == 5)
                            {

                                calculator.ListDuplicate(); // Mostrar os itens duplicados na Lista

                                break;


                            }
                            else if (choiceList == 6)
                            {

                                calculator.ListRemoveItens(); // Remover todos os itens da Lista

                                break;

                            }
                            else
                            {

                                print.PrintMessageError();  // Mensagem de Erro - Opção Inválida

                                break;

                            }

                        }
                        //---------------------- Fim do Laço de Repetição: Menu Lista ----------------------------------

                    }
                    else
                    {
                        Console.WriteLine(calculator.calculatorList);
                        messageError();

                    }
                }
                //---------------------- Fim do Laço de Repetição: Menu Sistema ----------------------------------

            }
        }
    }
}