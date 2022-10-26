
using System.Text.RegularExpressions;
using System.Xml.Linq;

class MainProgram {

    public delegate void MenuSystem();

    static void Main(string[] args) {

        //-------------------------- Criação de Objetos --------------------------------------

        ManipulationListPerson listPerson = new ManipulationListPerson();
        ManipulationListCalculator listCalculator = new ManipulationListCalculator();
        Calculator calculator = new Calculator();
        Person person = new Person();
        Person newPerson = new Person();
        PrintOut print = new PrintOut();

        //---------------------------- Lista Genérica ----------------------------------------

        List<string> listPersons = new List<string> { "Armando", "Pedro", "Isabella", "Gabriel" };

        //-------------------------- Criação de Delegates ------------------------------------

        MenuSystem menuRegister = new MenuSystem(print.PrintRegister);
        MenuSystem menuNewPerson = new MenuSystem(print.PrintNewPerson);
        MenuSystem menuPerson = new MenuSystem(print.PrintPerson);
        MenuSystem checkNameError = new MenuSystem(print.PrintCheckNameError);
        MenuSystem checkAgeError = new MenuSystem(print.PrintCheckAgeError);
        MenuSystem menuSystem = new MenuSystem(print.PrintInitialMenu);
        MenuSystem menuCalculator = new MenuSystem(print.PrintMenuCalculator);
        MenuSystem menuList = new MenuSystem(print.PrintMenuList);
        MenuSystem messageLater = new MenuSystem(print.PrintMessageLater);
        MenuSystem messageError = new MenuSystem(print.PrintMessageError);

        //------------------------------------------------------------------------------------

        menuRegister();
        int.TryParse(Console.ReadLine(), out int choiceRegister);

        if (choiceRegister == 1) {

            menuPerson(); // Mensagem de Resgistro da Pessoa

            Console.Write("\nINFORME SEU NOME: ");
            string name = Console.ReadLine();
            person.PersonName(name);

            if (!Regex.IsMatch(name, @"^[a-zA-Z]+$")) {

                checkNameError(); // Imprime Mensagem de Erro - Nome Inválido

            } else { // Caso a afirmativa for verdadeira, o algoritmo continua

                Console.Write("\nINFORME SUA IDADE: ");
                byte.TryParse(Console.ReadLine(), out byte choiceAge); // out - argumentos sejam passados por referência
                uint age = choiceAge; // Conversão Implícita
                person.PersonAge(age);

                if (age < 0 || age > 130) {

                    checkAgeError(); // Imprime Mensagem de Erro - Idade Inválida

                } else {

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
                            Console.WriteLine($"\tIDADE DO USUÁRIO: {person.PersonAge(age)} ANOS");

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

                                    object firstObj = firstValueNumber;         // Boxing
                                    object secondObj = secondValueNumber;

                                    Console.WriteLine(firstObj);
                                    Console.WriteLine(secondObj);

                                    listCalculator.ListAdd(firstObj);
                                    Console.WriteLine("--------------01----------------");
                                    listCalculator.ListAdd(secondObj);
                                    Console.WriteLine("--------------02----------------");

                                    Console.WriteLine("\nDESEJA CONTINUAR?");
                                    Console.WriteLine("\t1 - SIM\t\t2 - NÃO");
                                    Console.Write("\n-> ");

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

                                    object firstObj = firstValueNumber;         // Boxing
                                    object secondObj = secondValueNumber;

                                    listCalculator.ListAdd(firstObj);
                                    listCalculator.ListAdd(secondObj);

                                    Console.WriteLine("\nDESEJA CONTINUAR?");
                                    Console.WriteLine("\t1 - SIM\t\t2 - NÃO");
                                    Console.Write("\n-> ");

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

                                    object firstObj = firstValueNumber;         // Boxing
                                    object secondObj = secondValueNumber;

                                    listCalculator.ListAdd(firstObj);
                                    listCalculator.ListAdd(secondObj);

                                    Console.WriteLine("\nDESEJA CONTINUAR?");
                                    Console.WriteLine("\t1 - SIM\t\t2 - NÃO");
                                    Console.Write("\n-> ");

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

                                    object firstObj = firstValueNumber;         // Boxing
                                    object secondObj = secondValueNumber;

                                    listCalculator.ListAdd(firstObj);
                                    listCalculator.ListAdd(secondObj);

                                    Console.WriteLine("\nDESEJA CONTINUAR?");
                                    Console.WriteLine("\t1 - SIM\t\t2 - NÃO");
                                    Console.Write("\n-> ");

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

                                    //----------------------------- Imprimir Números da Lista -----------------------------------

                                    listCalculator.ListPrint();

                                    break;

                                } else if (choiceList == 2) {

                                    //----------------------- Imprimir a quantidade de Números na Lista -------------------------

                                    listCalculator.ListCountIntes();

                                    break;

                                } else if (choiceList == 3) {

                                    //------------------------- Imprimir em ordem crescente a Lista -----------------------------

                                    listCalculator.ListGrowning();

                                    break;

                                } else if (choiceList == 4) {

                                    //----------------------- Imprimir em ordem decrescente a Lista -----------------------------

                                    listCalculator.ListDescending();

                                    break;

                                } else if (choiceList == 5) {

                                    //------------------------- Imprimir Itens Duplicado na Lista -------------------------------

                                    listCalculator.ListDuplicateItens();

                                    break;

                                } else if (choiceList == 6) {

                                    //--------------------------- Remoção do Itens da Lista -------------------------------------

                                    listCalculator.ListRemoveItens();

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

        } else if (choiceRegister == 2) {

            menuNewPerson();
            Console.Write("\nINFORME SEU NOME: ");
            string newName = Console.ReadLine();

            Console.Write("\nINFORME SUA IDADE: ");
            int.TryParse(Console.ReadLine(), out int newAge);

            if (newName != null) {
                foreach (var n in listPersons) {
                    if (n.Equals(listPerson)) {

                        Console.WriteLine("NOME INDÍPONÍVEL");

                        break;
                        
                    }
                }
            }

        } else {

            messageError();

        }

        //---------------------------- Fim do Sistema -----------------------------------

    }
}