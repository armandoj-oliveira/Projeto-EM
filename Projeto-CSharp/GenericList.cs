using System.Collections.Generic;

class GenericList<T> {

    List<T> listCalculator = new List<T>();
    List<T> personsRegister = new List<T>();

}
class ManipulationListCalculator {

    List<double> listNumbers = new List<double>();

    //------------------------------- MÉTODOS PARA MANIPUAÇÂO DA LISTA ----------------------------------

    public void ListAdd(object number) {

        listNumbers.Add((double)number);

    }

    public void ListPrint() {

        if (listNumbers.Count == 0) {

            Console.WriteLine("\nNÃO EXISTE NENHUM NÚMERO NA LISTA!");

        } else {

            Console.WriteLine($"\nOS NÚMEROS INSERIDOS NO SISTEMA SÂO: ");

            foreach (var itens in listNumbers) {

                Console.WriteLine("\t{ " + itens + " }");
            }

        }

    }

    public void ListCountIntes() {

        listNumbers.Count();

        Console.WriteLine($"EXITEM {listNumbers.Count} ITENS NA LISTA!");

    }

    public void ListGrowning() {

        if (listNumbers.Count == 0) {

            Console.WriteLine("\nNÃO EXISTE NENHUM NÚMERO NA LISTA!");

        } else {

            listNumbers.Sort();
            Console.WriteLine("\nA ORDEM CRESCENTE DA LISTA DE NÚMEROS É: ");

            foreach (var itens in listNumbers) {

                Console.WriteLine("\t{ " + itens + " }");
            }

        }

    }

    public void ListDescending() {

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
    }

    public void ListDuplicateItens() {

        if (listNumbers.Count == 0) {

            Console.WriteLine("\nNÃO EXISTE NENHUM NÚMERO NA LISTA!");

        } else {

            var numDuplicate = listNumbers.GroupBy(x => x) // LINQ com expressão Lambda
                                          .Where(g => g.Count() > 1)
                                          .Select(x => new { ELEMENTO = x.Key, REPETE = x.Count() })
                                          .ToList();

            Console.WriteLine(String.Join(", ", numDuplicate));


        }
    }

    public void ListRemoveItens() {

        listNumbers.Clear();

        Console.WriteLine("\nLISTA ESVAZIDA COM SUCESSO!");

    }


}