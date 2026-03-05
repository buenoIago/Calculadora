
bool deveContinuar = true;

while (deveContinuar == true)
{
    Console.Clear();

    Console.WriteLine("----------------------------");
    Console.WriteLine("Calculadora, 2026!");
    Console.WriteLine("----------------------------");

    Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\nS - Sair");

    Console.WriteLine("Selecione a operação desejada: ");
    string operacaoSelecionada = Console.ReadLine();

    if (operacaoSelecionada == "s" || operacaoSelecionada == "S")
    {
        deveContinuar = false;
        Console.WriteLine("Encerrando o programa. Até mais...");
        continue;
    }

    Console.WriteLine("Digite o primeiro número: ");
    string strPrimeiroNumero = Console.ReadLine();

    Console.Write("Digite o segundo número: ");
    string strSegundoNumero = Console.ReadLine();

    Console.WriteLine();

    Console.WriteLine("O primeiro número digitado foi: " + strPrimeiroNumero);
    Console.WriteLine("O segundo número digitado foi: " + strSegundoNumero);

    Console.WriteLine();

    // int = numero inteiro
    int primeiroNumero = Convert.ToInt32(strPrimeiroNumero);
    int segundoNumero = Convert.ToInt32(strSegundoNumero);

    int resultado;

    if (operacaoSelecionada == "1")
    {
        resultado = primeiroNumero + segundoNumero;
    }
    else if (operacaoSelecionada == "2")
    {
        resultado = primeiroNumero - segundoNumero;
    }
    else if (operacaoSelecionada == "3")
    {
        resultado = primeiroNumero * segundoNumero;
    }
    else
    {
        if (segundoNumero == 0)
        {
            Console.WriteLine("Não é possível dividir por zero!");
            return;
        }
        resultado = primeiroNumero / segundoNumero;
    }
    Console.WriteLine("O resultado da operação é: " + resultado);

    Console.ReadLine();
}
