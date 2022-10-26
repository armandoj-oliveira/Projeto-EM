using System.Collections.Generic;
using System.Xml.Linq;

class GenericList<T> {

    public List<T> ListCalculator = new List<T>();
    public List<T> PersonsRegister = new List<T>();

}
class ManipulationListCalculator {

    GenericList<double> listNumbers = new GenericList<double>();

    //------------------------------- MÉTODOS PARA MANIPUAÇÂO DA LISTA ----------------------------------

    public void ListAdd(object number) {

        listNumbers.ListCalculator.Add((double)number);

    }

    public void ListPrint() {

        if (listNumbers.ListCalculator.Count == 0) {

            Console.WriteLine("\nNÃO EXISTE NENHUM NÚMERO NA LISTA!");

        } else {

            Console.WriteLine($"\nOS NÚMEROS INSERIDOS NO SISTEMA SÂO: ");

            foreach (var itens in listNumbers.ListCalculator) {

                Console.WriteLine("\t{ " + itens + " }");
            }

        }

    }

    public void ListCountIntes() {

        listNumbers.ListCalculator.Count();

        Console.WriteLine($"EXITEM {listNumbers.ListCalculator.Count} ITENS NA LISTA!");

    }

    public void ListGrowning() {

        if (listNumbers.ListCalculator.Count == 0) {

            Console.WriteLine("\nNÃO EXISTE NENHUM NÚMERO NA LISTA!");

        } else {

            listNumbers.ListCalculator.Sort();
            Console.WriteLine("\nA ORDEM CRESCENTE DA LISTA DE NÚMEROS É: ");

            foreach (var itens in listNumbers.ListCalculator) {

                Console.WriteLine("\t{ " + itens + " }");
            }

        }

    }

    public void ListDescending() {

        if (listNumbers.ListCalculator.Count == 0) {

            Console.WriteLine("\nNÃO EXISTE NENHUM NÚMERO NA LISTA!");

        } else {

            listNumbers.ListCalculator.Sort();
            listNumbers.ListCalculator.Reverse();
            Console.WriteLine("\nA ORDEM DECRESCENTE DA LISTA DE NÚMEROS É: ");

            foreach (var itens in listNumbers.ListCalculator) {

                Console.WriteLine("\t{ " + itens + " }");
            }

        }
    }

    public void ListDuplicateItens() {

        if (listNumbers.ListCalculator.Count == 0) {

            Console.WriteLine("\nNÃO EXISTE NENHUM NÚMERO NA LISTA!");

        } else {

            var numDuplicate = listNumbers.ListCalculator.GroupBy(x => x) // LINQ com expressão Lambda
                                                         .Where(g => g.Count() > 1)
                                                         .Select(x => new { ELEMENTO = x.Key, REPETE = x.Count() })
                                                         .ToList();

            Console.WriteLine(String.Join(", ", numDuplicate));

        }
    }

    public void ListRemoveItens() {

        listNumbers.ListCalculator.Clear();

        Console.WriteLine("\nLISTA ESVAZIDA COM SUCESSO!");

    }
}

class ManipulationListPerson {

    GenericList<string> listPersons = new GenericList<string>();

    public void personAdd(string name) {

        listPersons.PersonsRegister.Add(name);

    }
}
