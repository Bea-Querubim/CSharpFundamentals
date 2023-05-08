
internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundo => 10s = 10 segundos");
        Console.WriteLine("M = Minuto => 1m = 1 minuto");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length - 1, 1));// data.Length-1 => pega a posição    | 1 => pega quantos caracateres a partir da posição informada
        int time = int.Parse(data.Substring(0, data.Length - 1));//pega a string da posição zero até o tamanho-1

        int multiplier = 1;

        if (type == 'm') multiplier = 60;
        if ((type != 's' && type != 'm') || time == 0)
        {
            Console.Clear();
            System.Environment.Exit(0); //tratativas
        }

        PreStart(time * multiplier);
    }

static void PreStart(int time){
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go...");
    Thread.Sleep(2000);
    Start(time);
    
}
    static void Start(int time)
    {
        int currentTime = 0;

        while (currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Fishing Stopwatch");
        Thread.Sleep(2500);
        Console.Clear();
        System.Environment.Exit(0);
    }
}