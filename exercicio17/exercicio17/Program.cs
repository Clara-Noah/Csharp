using Microsoft.Win32.SafeHandles;
using System;
public class Exercicio17 {

    public static void Main(string[] args)
    {
        //String é usada para nomes ou letras numa variavel enquanto int é apenas para numeros
        String[] listafilmes = { "harry potter", "zoro", "simpsons" };
        int[] ano = { 1999, 2010, 2014 };

        Console.WriteLine("Lista de filmes: ");

        //foreach quando usado salta de linha automaticamente enquanto o for não
        for (int contador = 0; contador < listafilmes.Length; contador++ )
        {
            Console.WriteLine(listafilmes[contador]+ " - " + ano[contador]);
            }
    }
}
