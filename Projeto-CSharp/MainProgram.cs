using System.Collections;
using System.Text.RegularExpressions;

class MainProgram {

    public delegate void MenuSystem();

    static void Main(string[] args) {

        //-------------------------- Criação de Objetos --------------------------------------

        Calulator calculator = new Calulator();
        Person person = new Person();
        PrintOut print = new PrintOut();

        //-------------------------- Criação de Delegates --------------------------------------

        MenuSystem menuPerson = new MenuSystem(print.PrintPerson);
        MenuSystem checkNameError = new MenuSystem(print.PrintCheckNameError);
        MenuSystem checkAgeError = new MenuSystem(print.PrintCheckAgeError);
        MenuSystem menuSystem = new MenuSystem(print.PrintInitialMenu);
        MenuSystem menuCalculator = new MenuSystem(print.PrintMenuCalculator);
        MenuSystem menuList = new MenuSystem(print.PrintMenuList);
        MenuSystem messageLater = new MenuSystem(print.PrintMessageLater);
        MenuSystem messageError = new MenuSystem(print.PrintMessageError);

        //----------------------------------------------------------------

        menuPerson(); // Mensagem de Resgistro da Pessoa

        Console.Write("\nINFORME SEU NOME: ");
        string name = Console.ReadLine();
        person.PersonName(name);

        if (!Regex.IsMatch(name, @"^[a-zA-Z]+$")) // Indica se a expressão regular encontra uma correspondência na cadeia de caracteres de entrada.
        {                                         // Caso essa afirmativa seja falsa

            checkNameError(); // Imprime Mensagem de Erro - Nome Inválido

        } else // Caso a afirmativa for verdadeira, o algoritmo continua
          {

            Console.Write("\nINFORME SUA IDADE: ");
            byte.TryParse(Console.ReadLine(), out byte choiceAge); // out - argumentos sejam passados por referência
            int age = choiceAge; // Conversão Implícita
            person.PersonAge(age);

            if (age < 1 || age > 110) // Verificar a Idade do Usuário é menor que 0 ou maior que 100
            {                         // Caso essa afirmativa seja verdadeira

                checkAgeError(); // Imprime Mensagem de Erro - Idade Inválida

            } else   // Caso a afirmativa for falsa, o algoritmo continua
              {

                int i = 1;


                //---------------------- Laço de Repetição: Menu Sistema --------------------------------------

                while (i != 0) {

                    menuSystem();
                    int.TryParse(Console.ReadLine(), out int choiceMenu); 

                    if (choiceMenu == 0) {

                        messageLater(); // Mensagem de Despedida
                        break;

                    } else if (choiceMenu == 1) {

                        print.PrintDataPerson(); // Mensagem de Dados do Usuário
                        Console.WriteLine($"\tNOME DO USUÁRIO: {person.PersonName(name)}");
                        Console.WriteLine($"\tNOME DO USUÁRIO: {person.PersonAge(age)} ANOS");

                    } else if (choiceMenu == 2) {

                        menuCalculator();
                        int.TryParse(Console.ReadLine(), out int choiceCalculatorOperations);

                        int j = 1;

                        //---------------------- Laço de Repetição: Menu Calculadora --------------------------------------

                        while (j != 0) {
                            if (choiceCalculatorOperations == 0) {

                                messageError();

                                break; // Voltar para o Menu do Sistema

                            } else if (choiceCalculatorOperations == 1) {

                                //------------------------- Método de Adição ---------------------------------------

                                Console.Write("\nINFORME O PRIMEIRO NÚMERO: ");
                                double.TryParse(Console.ReadLine(), out double firstValueNumber);

                                /*
                                 * Conversão Explícita - Possiblidade de Perda de Memória
                                 * 
                                 * Console.Write("\nINFORME O PRIMEIRO NÚMERO: ");
                                 * double.TryParse(Console.ReadLine(), double out firstNumber);
                                 * 
                                 * int firstValueNumber = (int) firstNumber;
                                 * 
                                 */

                                Console.Write("\nINFORME O SEGUNDO NÚMERO: ");
                                double.TryParse(Console.ReadLine(), out double secondValueNumber);

                                calculator.Addition(firstValueNumber, secondValueNumber);

                                Console.WriteLine($"\nA ADIÇÃO ENTRE OS NÚMEROS {firstValueNumber} E {secondValueNumber} É IGUAL A: {calculator.Result}");

                                calculator.calculatorList.Add(firstValueNumber);
                                calculator.calculatorList.Add(secondValueNumber);

                                Console.WriteLine("\n DESEJA CONTINUAR? ");
                                Console.WriteLine("\t1 - SIM\t\t2 - NÃO");

                                int.TryParse(Console.ReadLine(), out int choiceContinue);

                                if (choiceContinue == 1) {

                                    continue;

                                } else if (choiceContinue == 2) {

                                    break;

                                } else {

                                    messageError(); // Mensagem de Erro - Opção Inválida

                                    break;

                                }
                                //------------------------- Fim do Método de Adição ---------------------------------------

                            } else if (choiceCalculatorOperations == 2) {

                                //------------------------- Método de Subtração ---------------------------------------

                                Console.Write("\nINFORME O PRIMEIRO NÚMERO: ");
                                double.TryParse(Console.ReadLine(), out double firstValueNumber);

                                Console.Write("\nINFORME O SEGUNDO NÚMERO: ");
                                double.TryParse(Console.ReadLine(), out double secondValueNumber);

                                calculator.Subtraction(firstValueNumber, secondValueNumber);

                                Console.WriteLine($"\nA SUBTRAÇÃO ENTRE OS NÚMEROS {firstValueNumber} E {secondValueNumber} É IGUAL A: {calculator.Result}");

                                calculator.calculatorList.Add(firstValueNumber);
                                calculator.calculatorList.Add(secondValueNumber);

                                Console.WriteLine("\n DESEJA CONTINUAR? ");
                                Console.WriteLine("\t1 - SIM\t\t2 - NÃO");

                                int.TryParse(Console.ReadLine(), out int choiceContinue);

                                if (choiceContinue == 1) {

                                    continue;

                                } else if (choiceContinue == 2) {

                                    break;

                                } else {

                                    messageError(); // Mensagem de Erro - Opção Inválida

                                    break;

                                }
                                //------------------------- Fim do Método de Subtração ---------------------------------------

                            } else if (choiceCalculatorOperations == 3) {

                                //------------------------- Método de Multiplicação ---------------------------------------

                                Console.Write("\nINFORME O PRIMEIRO NÚMERO: ");
                                double.TryParse(Console.ReadLine(), out double firstValueNumber);

                                Console.Write("\nINFORME O SEGUNDO NÚMERO: ");
                                double.TryParse(Console.ReadLine(), out double secondValueNumber);

                                calculator.Multiplication(firstValueNumber, secondValueNumber);

                                Console.WriteLine($"\nA MULTIPLICAÇÃO ENTRE OS NÚMEROS {firstValueNumber} E {secondValueNumber} É IGUAL A: {calculator.Result}");

                                calculator.calculatorList.Add(firstValueNumber);
                                calculator.calculatorList.Add(secondValueNumber);

                                Console.WriteLine("\n DESEJA CONTINUAR? ");
                                Console.WriteLine("\t1 - SIM\t\t2 - NÃO");

                                int.TryParse(Console.ReadLine(), out int choiceContinue);

                                if (choiceContinue == 1) {

                                    continue;

                                } else if (choiceContinue == 2) {

                                    break;

                                } else {

                                    messageError(); // Mensagem de Erro - Opção Inválida

                                    break;

                                }
                                //------------------------- Fim do Método de Multiplicação ---------------------------------------

                            } else if (choiceCalculatorOperations == 4) {

                                //------------------------- Método de Divisão ---------------------------------------

                                Console.Write("\nINFORME O PRIMEIRO NÚMERO: ");
                                double.TryParse(Console.ReadLine(), out double firstValueNumber);

                                Console.Write("\nINFORME O SEGUNDO NÚMERO: ");
                                double.TryParse(Console.ReadLine(), out double secondValueNumber);

                                calculator.Division(firstValueNumber, secondValueNumber);

                                Console.WriteLine($"\nA DIVISÃO ENTRE OS NÚMEROS {firstValueNumber} E {secondValueNumber} É IGUAL A: {calculator.Result}");

                                calculator.calculatorList.Add(firstValueNumber);
                                calculator.calculatorList.Add(secondValueNumber);

                                Console.WriteLine("\n DESEJA CONTINUAR? ");
                                Console.WriteLine("\t1 - SIM\t\t2 - NÃO");

                                int.TryParse(Console.ReadLine(), out int choiceContinue);

                                if (choiceContinue == 1) {

                                    continue;

                                } else if (choiceContinue == 2) {

                                    break;

                                } else {

                                    messageError(); // Mensagem de Erro - Opção Inválida

                                    break;

                                }
                                //------------------------- Fim do Método de Divisão ---------------------------------------

                            } else {

                                messageError(); // Mensagem de Erro - Opção Inválida

                                break;

                            }
                        }
                        //---------------------- Fim do Laço de Repetição: Menu Calculadora ----------------------------------

                    } else if (choiceMenu == 3) {

                        menuList();
                        int.TryParse(Console.ReadLine(), out int choiceList);

                        int k = 1;

                        //---------------------- Laço de Repetição: Menu Lista --------------------------------------

                        while (k != 0) {

                            if (choiceList == 0) {

                                break;

                            } else if (choiceList == 1) {


                                calculator.ListCaculator(); // Verifica se tem itens na Lista. 
                                                            // Se não tiver nada na Lista, imprime a mensagem que não contém nada
                                                            // Se tiver algo na Lista, imprime na tela os valores
                                break;

                            } else if (choiceList == 2) {

                                calculator.ListCalculatorCount(); // Contar quantos itens tem na Lista

                                break;

                            } else if (choiceList == 3) {


                                calculator.ListCalculatorGrowning(); // Mostrar os itens da lista em ordem crescente

                                break;

                            } else if (choiceList == 4) {


                                calculator.ListCalculatorDecreasing(); // Mostrar os itens da lista em ordem decrescente

                                break;


                            } else if (choiceList == 5) {

                                calculator.ListCalculatorDuplicate(); // Mostrar os itens duplicados na Lista

                                break;


                            } else if (choiceList == 6) {

                                calculator.ListCalculatorRemove(); // Remover todos os itens da Lista

                                break;

                            } else {

                                print.PrintMessageError();  // Mensagem de Erro - Opção Inválida

                                break;

                            }

                        }
                        //---------------------- Fim do Laço de Repetição: Menu Lista ----------------------------------

                    } else {

                        Console.Clear();

                        messageError();

                    }
                }

                //---------------------- Fim do Laço de Repetição: Menu Sistema ----------------------------------

            }
        }

        //---------------------------- Fim do Sistema -----------------------------------

    }
}