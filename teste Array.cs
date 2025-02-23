using System;

public class teste_Arrays
{
     public static void Main(string[] args)
     {
        //Array
        int[] idadeAlunos = { 12, 14, 30, 17};
        //percorrer com array com for//
        Console.WriteLine("idade percorrida com for: ");
        for (int contador = 0; contador < idadeAlunos.Length; contador++)
        {
            Console.WriteLine(idadeAlunos[contador]);
        }
        //percorrer com array com foreach//
        Console.WriteLine("idade percorrida com foreach: ");
        foreach (int idade in idadeAlunos) 
        {
            Console.WriteLine(idade);
        }
        
     }
}
