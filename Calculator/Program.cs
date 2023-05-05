internal class Program
{
    private static void Main(string[] args)
    {
        // criação dos metodos
        /*Soma();
        Subtracao();
        Divisao();
        Multiplicacao();*/
        Menu();
    }
    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("############   CALCULADORA   ############\n");
        Console.WriteLine("1 - Soma ");
        Console.WriteLine("2 - Subtração ");
        Console.WriteLine("3 - Divisão ");
        Console.WriteLine("4 - Multiplicação ");
        Console.WriteLine(" ----- ");
        Console.WriteLine("0 - Sair");
        Console.WriteLine(" **************************** \n");

        Console.Write("Escolha uma operação: ");
        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 0: Console.Clear(); break;//System.Environment.Exit(0);
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            default: Menu(); break;
        }

    }
    static void Soma()
    {
        Console.Clear();
        //soma
        Console.WriteLine("############  SOMA  ############\n");
        Console.Write("Digite o primeiro valor: ");
        double var1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        double var2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");

        double resultado = var1 + var2;
        /* possibilidades:
        Console.WriteLine("O resultado da soma é " + resultado);
        Console.WriteLine("O resultado da soma é " + (var1 + var2));
        
        Console.WriteLine($"O resultado da soma é (var1 + var2)");
        */
        Console.WriteLine($"O resultado da soma é {resultado}");
        Console.WriteLine("");
        Console.ReadKey();
        Menu();

    }
    static void Subtracao()
    {
        Console.Clear();

        Console.WriteLine("############  SUBTRACAO  ############\n");
        Console.Write("Digite o primeiro valor: ");
        float var1 = float.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        float var2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = var1 - var2;
        Console.WriteLine($"O resultado da subtração é {resultado}");
        Console.ReadKey();
        Menu();

    }

    static void Divisao()
    {
        Console.Clear();

        Console.WriteLine("############  DIVISÃO  ############\n");
        Console.Write("Digite o primeiro valor: ");
        float var1 = float.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        float var2 = float.Parse(Console.ReadLine());


        Console.WriteLine("");

        float resultado = var1 / var2;
        Console.WriteLine($"O resultado da divisao é {resultado}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplicacao()
    {
        Console.Clear();

        Console.WriteLine("############  MULTIPLICAÇÃO  ############\n");
        Console.Write("Digite o primeiro valor: ");
        float var1 = float.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor: ");
        float var2 = float.Parse(Console.ReadLine());

        Console.WriteLine("");

        float resultado = var1 * var2;
        Console.WriteLine($"O resultado da divisao é {resultado}");
        Console.ReadKey();
        Menu();
    }
}