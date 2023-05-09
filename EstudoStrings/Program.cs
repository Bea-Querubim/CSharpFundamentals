using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
//GUID 
        var id = Guid.NewGuid(); // guid - valor randomico - hash
        //id.ToString(); //para converter ele para string 
        // id.ToString().Substring(0,8)); //ou para  substring
        id =new Guid(); // apenas inicia o Guid 00000000-0000-0000-0000-000000000000
        Console.WriteLine(id);


 //verificar se existe a palavra dentro do texto - Contains 
        var texto = "Esse texto é um teste";
        Console.WriteLine(texto.Contains("teste")); // compara e identifica se existe a palavra ( camelcase tem diferença)
        Console.WriteLine(texto.Contains("Teste")); //contains retorna true / false
        Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); //ignora o camel case


// compara 2 strings exatamente iguais - CompareTo
        var texto2 = "Testando";
        Console.WriteLine(texto2.CompareTo("teste")); // camelcase tem diferença // compara 2 strings exatamente iguais
        Console.WriteLine(texto2.CompareTo("Teste")); //contains retorna 0 ("verdadeiro")ou 1 ("false")


        var texto3 = "Esse é mais um texto de teste";
//statsWith
        Console.WriteLine(texto3.StartsWith("Este")); //camelcase - true
        Console.WriteLine(texto3.StartsWith("este")); //camelcase - false
        Console.WriteLine(texto3.StartsWith("este", StringComparison.OrdinalIgnoreCase)); //ignora o camelcase - true


//endsWith
        Console.WriteLine(texto3.EndsWith("teste")); //camelcase - true
        Console.WriteLine(texto3.EndsWith("Teste")); //camelcase - false
        Console.WriteLine(texto3.EndsWith("Teste", StringComparison.OrdinalIgnoreCase)); //ignora o camelcase - true


//Equals - compara se é exatamente igual
        //se estende nao apenas para string serve para qlq objeto
        //int  - int  // string - string // etc
        Console.WriteLine(texto3.Equals("Esse texto é um teste")); //camelcase - true
        Console.WriteLine(texto3.Equals("ESSE texto é um TESTE")); //camelcase - false
        Console.WriteLine(texto3.Equals("ESSE texto é um TESTE", StringComparison.OrdinalIgnoreCase)); //ignora o camelcase - true


//índices - usado em listas
//string é uma 'lista'/ conjunto de char

//IndexOf - mostra a  pimeira posição do char/palavra (começa em 0)
    var texto4 = "Testando indices!";
    Console.WriteLine(texto4.IndexOf("é")); // indice da letra
    Console.WriteLine(texto4.IndexOf("indices")); // em qual indice comeca a palavra
//LastIndexOf - ultima letra da frase
    Console.WriteLine(texto4.LastIndexOf("e")); // indice da ultima letra


//ToUpper - converte maiusculo
    Console.WriteLine(texto4.ToUpper()); // indice da letra
    

//ToLower - converte minusculo
    Console.WriteLine(texto4.ToLower());


//inserindo caracteres - palavras/letras
    Console.WriteLine(texto4.Insert(8,"  os")); // pede o indice e entao a palavra/letra


//removedo caracteres - palavras/letras
    Console.WriteLine(texto4.Remove(8,2)); // pede o indice e entao quantos espaços vai remover!


//tamanho
    Console.WriteLine(texto4.Length); // retorna quantos caracteres tem na string

    var texto5 = " esse texto é para usar o replace   ";
//replace
    Console.WriteLine(texto5.Replace("e", "X")); // troca as letras "e" por "X"
    Console.WriteLine(texto5.Replace("X", "e")); // troca as letras "e" por "X"

//Split
    var divisao = texto5.Split(" "); // "corta" a frase/string e as divide quando encontrar espaço (" ");
    Console.WriteLine(divisao[0]);
    Console.WriteLine(divisao[1]);
    Console.WriteLine(divisao[2]);
    Console.WriteLine(divisao[3]);

    
    var resultado = texto5.Substring(5, texto5.LastIndexOf("o")); //mostra ate o 1 caractere "o"
    Console.WriteLine(resultado);

 //Trim
 Console.WriteLine(texto5.Trim());  // limpar os espaços do começo e do final da string
 

 //StringBuilder
 //evita problemas de memoria na aplicação - Para caso de multiplas linhas ou use o @ ou o stringBuilder

    var texto = new StringBuilder(); // é um construtor 
    // é um StringBuilder e não uma String!
    texto.Append("Esse texto ");
    texto.Append("é um teste ");
    texto.Append("Esse teste é ");
    texto.Append("outro texto ");

    //texto.ToString(); para converter para String!
    Console.WriteLine(texto);

    }
}