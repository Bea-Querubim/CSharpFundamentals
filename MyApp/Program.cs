internal class Program
{
    private static void Main(string[] args)
    {
        /* instanciar uma struct,sem parametro
         * 
        Product mouse= new Product();
         * 
         * se for sem parametro ele pula o metodo construtor!
         * os valores mantem 0 ou \0 (para string)
         */
        //instanciar uma struct - opção com parametro

        var mouse = new Product(1, "Mouse gamer", 300.90, EProductType.Product);
        var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);
        // para sobreescrever ou alterar valores
        mouse.Id = 55;

        Console.WriteLine(mouse.Id);
        Console.WriteLine(mouse.Name);
        Console.WriteLine(mouse.Price);
        Console.WriteLine(mouse.Type); //traz o valor em texto
        Console.WriteLine((int)mouse.Type); //traz o valor em numeros

    }
}
struct Product
{
    //metodo construtor - como funciona
    public Product(int id, string name, double price, EProductType type)// tem que conter o mesmo nome da struct
    {
        Id = id; // propriedade recebe parametro
        Name = name; // propriedade recebe parametro 
        Price = price; // propriedade recebe parametro
        Type = type;  // type com minusculo é o parametro
    }

    //struct 
    public int Id;  //propriedade
    public string Name;  //propriedade
    public double Price;  //propriedade
    public EProductType Type; // EProductType -> é o tipo

    public double PriceInDolar(double dolar)
    {
        return dolar * Price; //dolar -> parametro
    }
}

//não pode estar dentro de uma classe - esta no mesmo nivel de estrutura!
enum EProductType
{
    Product = 1,
    Service = 2
}