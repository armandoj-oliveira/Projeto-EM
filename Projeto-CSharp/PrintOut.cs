
class PrintOut
{
    public void PrintRegistrationPerson() // Mensagem para Registro do Usuário
    {
        Console.WriteLine("//-------------------------------------------------------------------------------//");
        Console.WriteLine("//---------------------- SEJA MUITO(A) BEM VINDO(A)! ----------------------------//");
        Console.WriteLine("//------------------ ANTES DE TUDO, REALIZE SEU CADASTRO! -----------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//");
    }

    public void printCheckNameError() // Mensagem Erro - Nome Invalido
    {

        Console.WriteLine("\n//-------------------------------------------------------------------------------//");
        Console.WriteLine("//---------------------------- NOME INVÁLIDO! -----------------------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//");

    }

    public void printCheckAgeError() // Mensagem Erro - Idade Invalidada
    {

        Console.WriteLine("\n//-------------------------------------------------------------------------------//");
        Console.WriteLine("//--------------------------- IDADE INVÁLIDA! -----------------------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//");

    }

    public void PrintInitialMenu() // Mensagem de Menu do Sistema
    {
        Console.WriteLine("\n//-------------------------------------------------------------------------------//");
        Console.WriteLine("//------------------------- BEM VINDO(A) DE NOVO(A)! ----------------------------//");
        Console.WriteLine("//--------------- DIGITE UM NÚMERO PARA NAEVGAR NO NOSSO MENU! ------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//");

        Console.WriteLine("\n 1 - IMPRIMIR DADOS DO USUÁRIO.");
        Console.WriteLine(" 2 - INICIAR AS OPERAÇÕES NO SISTEMA.");
        Console.WriteLine(" 3 - INFORMAÇÕES DO NÚMEROS JÁ DIGITADOS.");
        Console.WriteLine(" 0 - SAIR.\n");

        Console.Write("DIGITE UM NÚMERO: ");
    }

    public void PrintMenuCalculator() //  Mensagem de Menun da Calculadora
    {
        Console.WriteLine("\n//-------------------------------------------------------------------------------//");
        Console.WriteLine("//---------------------------- MENU CALCULADORA! --------------------------------//");
        Console.WriteLine("//-------------- DIGITE UM NÚMERO PARA NAEVGAR NO NOSSO MENU! -------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//\n");

        Console.WriteLine(" 1 - ADIÇÃO.");
        Console.WriteLine(" 2 - SUBTRAÇÃO.");
        Console.WriteLine(" 3 - MULTIPLICAÇÃO.");
        Console.WriteLine(" 4 - DIVISÃO.");
        Console.WriteLine(" 0 - VOLTAR\n");

        Console.Write("DIGITE UM NÚMERO: ");
    }

    public void PrintMenuList() // Mensagem de Menu da Lista
    {
        Console.WriteLine("\n//-------------------------------------------------------------------------------//");
        Console.WriteLine("//------------------- INFORMAÇÕES DE NÚMEROS JÀ DIGITADOS! ------------------------//");
        Console.WriteLine("//-------------- DIGITE UM NÚMERO PARA NAEVGAR NO NOSSO MENU! ---------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//\n");

        Console.WriteLine(" 1 - LISTA DE NÚMEROS.");
        Console.WriteLine(" 2 - QUANTIDADE DE NÚMEROS NA LISTA.");
        Console.WriteLine(" 3 - LISTA DE NÚMEROS EM ORDEM CRESCENTE.");
        Console.WriteLine(" 4 - LISTA DE NÚMEROS ME ORDEM DECRESCEANTE.");
        Console.WriteLine(" 5 - LISTA DE NÚEMEROS DUPLICADOS.");
        Console.WriteLine(" 6 - LIMPAR LISTA.");
        Console.WriteLine(" 0 - VOLTAR\n");

        Console.Write("DIGITE UM NÚMERO: ");
    }

    public void PrintDataPerson(Person p) // Mensagem de Dados do Usuário
    {
        Console.WriteLine("//-------------------------------------------------------------------------------//");
        Console.WriteLine("//---------------------------- DADOS DO USUÁRIO! --------------------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//");
        Console.WriteLine($"\n\tNOME: {p.namePerson}");
        Console.WriteLine($"\n\tIDADE: {p.agePerson} anos");
    }

    public void PrintMessageLater() // Mensagem de Despedida
    {
        Console.WriteLine("\n//-------------------------------------------------------------------------------//");
        Console.WriteLine("//-------------------------- ATÉ OUTRA HORA! ------------------------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//");
    }

    public void PrintMessageError() // Mensagem de Error - Opção
    {
        Console.WriteLine("//-------------------------------------------------------------------------------//");
        Console.WriteLine("//--------------------------- OPÇÃO INVÁLIDA! -----------------------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//");
    }
}