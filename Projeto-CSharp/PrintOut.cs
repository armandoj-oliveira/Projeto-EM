class PrintOut {

    public void PrintRegister() {

        Console.WriteLine("\n//-------------------------------------------------------------------------------//");
        Console.WriteLine("//-------------- ANTES DE TUDO, REALIZE SEU LOGIN/CADASTRO! ---------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//");

        Console.WriteLine("\n1 - JÁ SOU CADASTRADO NO SISTEMA");
        Console.WriteLine("2 - NÃO SOU CADASTRADO NO SISTEMA");
        Console.WriteLine("0 - SAIR");

    }

    //------------------------- Mensagem para Registro do Usuário ---------------------------------------
    public void PrintPerson() {

        Console.WriteLine("\n//-------------------------------------------------------------------------------//");
        Console.WriteLine("//---------------------- SEJA MUITO(A) BEM VINDO(A)! ----------------------------//");
        Console.WriteLine("//--------------------------- REALIZE SEU LOGIN! --------------------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//");

    }

    public void PrintNewPerson() {

        Console.WriteLine("\n//-------------------------------------------------------------------------------//");
        Console.WriteLine("//---------------------- SEJA MUITO(A) BEM VINDO(A)! ----------------------------//");
        Console.WriteLine("//----------------------- REALIZE SEU SEU CADASTRO! -----------------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//");

    }

    //-------------------------  Mensagem Erro - Nome Invalido ---------------------------------------
    public void PrintCheckNameError() {

        Console.WriteLine("\n//-------------------------------------------------------------------------------//");
        Console.WriteLine("//---------------------------- NOME INVÁLIDO! -----------------------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//");

    }

    //------------------------- Mensagem Erro - Idade Invalidada ---------------------------------------
    public void PrintCheckAgeError() {

        Console.WriteLine("\n//-------------------------------------------------------------------------------//");
        Console.WriteLine("//--------------------------- IDADE INVÁLIDA! -----------------------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//");

    }

    //------------------------- Mensagem de Menu do Sistema ---------------------------------------
    public void PrintInitialMenu() {

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

    //------------------------- Mensagem de Menun da Calculadora ---------------------------------------
    public void PrintMenuCalculator() {

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

    //------------------------- Mensagem de Menu da Lista ---------------------------------------
    public void PrintMenuList() {

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

    //------------------------- Mensagem de Dados do Usuário ---------------------------------------
    public void PrintDataPerson() {

        Console.WriteLine("\n//-------------------------------------------------------------------------------//");
        Console.WriteLine("//---------------------------- DADOS DO USUÁRIO! --------------------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//\n");

    }

    //------------------------- Mensagem de Despedida ---------------------------------------
    public void PrintMessageLater() {

        Console.WriteLine("\n//-------------------------------------------------------------------------------//");
        Console.WriteLine("//-------------------------- ATÉ OUTRA HORA! ------------------------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//");
    }


    //------------------------- Mensagem de Error - Opção ---------------------------------------
    public void PrintMessageError() {

        Console.WriteLine("\n//-------------------------------------------------------------------------------//");
        Console.WriteLine("//--------------------------- OPÇÃO INVÁLIDA! -----------------------------------//");
        Console.WriteLine("//-------------------------------------------------------------------------------//");

    }
}