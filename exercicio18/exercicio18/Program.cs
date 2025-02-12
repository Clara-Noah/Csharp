using System;
public class Exercicio18
{

    public static void Main(string[] args)
    {
        //String é usada para nomes ou letras numa variavel enquanto int é apenas para numeros inteiros, sempre quando usado nomes em String tem que ser entre " "
        String[] cidades = { "lisboa", "porto", "coimbra", "faro", "braga" };
        int[] habitantes = { 545000, 237000, 143000, 118000, 193000 };

        Console.WriteLine("Cidades e sua população: ");

        //foreach quando usado salta de linha automaticamente enquanto o for não, podemos usar + " " + para adicionar algo entre os arrays
        for (int contador = 0; contador < cidades.Length; contador++)
        {
            Console.WriteLine($"{cidades[contador]} - {habitantes[contador]} habitantes");
        }
    }
}

// feito por Aimar e Clara
