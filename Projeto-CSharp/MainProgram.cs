using System.Collections;
using System.Text.RegularExpressions;

class MainProgram {

    public delegate void MenuSystem();

    static void Main(string[] args) {

        //---------------------------- Lista Genérica ----------------------------------------

        List<double> listNumbers = new List<double>();

        //-------------------------- Criação de Objetos --------------------------------------

        Calculator calculator = new Calculator();
        Person person = new Person();
        PrintOut print = new PrintOut();

        //-------------------------- Criação de Delegates ------------------------------------

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

                                listNumbers.Add(firstValueNumber);
                                listNumbers.Add(secondValueNumber);

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

                                listNumbers.Add(firstValueNumber);
                                listNumbers.Add(secondValueNumber);

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

                                listNumbers.Add(firstValueNumber);
                                listNumbers.Add(secondValueNumber);

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

                                listNumbers.Add(firstValueNumber);
                                listNumbers.Add(secondValueNumber);

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

                                //----------------------------- Imprimir Números da Lista -----------------------------------

                                if (listNumbers.Count == 0) {                                    // Verifica se tem itens na Lista. 
                                                                                                 // Se não tiver nada na Lista, imprime a mensagem que não contém nada
                                    Console.WriteLine("\nNÃO EXISTE NENHUM NÚMERO NA LISTA!");   // Se tiver algo na Lista, imprime na tela os valores

                                } else {

                                    Console.WriteLine($"\nOS NÚMEROS INSERIDOS NO SISTEMA SÂO: ");

                                    foreach (var itens in listNumbers) {
                                        Console.WriteLine("\t{ " + itens + " }");
                                    }

                                }

                                break;

                                //---------------------------- Fim: Imprimir Números da Lista -------------------------------

                            } else if (choiceList == 2) {

                                //----------------------- Imprimir a quantidade de Números na Lista -------------------------

                                Console.WriteLine($"EXITEM {listNumbers.Count} ITENS NA LISTA!");

                                break;

                                //-------------------- Fim: Imprimir a quantidade de Números na Lista -----------------------

                            } else if (choiceList == 3) {

                                //------------------------- Imprimir em ordem crescente a Lista -----------------------------

                                if (listNumbers.Count == 0) {

                                    Console.WriteLine("\nNÃO EXISTE NENHUM NÚMERO NA LISTA!");

                                } else {

                                    listNumbers.Sort();
                                    Console.WriteLine("\nA ORDEM CRESCENTE DA LISTA DE NÚMEROS É: ");

                                    foreach (var itens in listNumbers) {
                                        Console.WriteLine("\t{ " + itens + " }");
                                    }

                                }

                                break;

                                //---------------------- Fim: Imprimir em ordem crescente a Lista ---------------------------

                            } else if (choiceList == 4) {

                                //----------------------- Imprimir em ordem decrescente a Lista -----------------------------

                                if (listNumbers.Count == 0) {

                                    Console.WriteLine("\nNÃO EXISTE NENHUM NÚMERO NA LISTA!");

                                } else {

                                    listNumbers.Sort();
                                    listNumbers.Reverse();
                                    Console.WriteLine("\nA ORDEM DECRESCENTE DA LISTA DE NÚMEROS É: ");

                                    foreach (var itens in listNumbers) {
                                        Console.WriteLine("\t{ " + itens + " }");
                                    }

                                }

                                break;

                                //--------------------- Fim: Imprimir em ordem decrescente a Lista --------------------------

                            } else if (choiceList == 5) {

                                //------------------------- Imprimir Itens Duplicado na Lista -------------------------------

                                if (listNumbers.Count == 0) {

                                    Console.WriteLine("\nNÃO EXISTE NENHUM NÚMERO NA LISTA!");

                                } else {

                                    var numDuplicate = listNumbers.GroupBy(x => x) // LINQ com expressão Lambda
                                                                  .Where(g => g.Count() > 1)
                                                                  .Select(x => new { ELEMENTO = x.Key, REPETE = x.Count() })
                                                                  .ToList();

                                    Console.WriteLine(String.Join(", ", numDuplicate));

                                }

                                break;

                                //----------------------- Fim: Imprimir Itens Duplicado na Lista ----------------------------

                            } else if (choiceList == 6) {

                                //--------------------------- Remoção do Itens da Lista -------------------------------------

                                listNumbers.Clear();

                                Console.WriteLine("\nLISTA ESVAZIDA COM SUCESSO!");

                                break;

                                //------------------------- Fim: Remoção do Itens da Lista ----------------------------------

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