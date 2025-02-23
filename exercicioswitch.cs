using System;

public class Exemplo
{
    static void Main(string[] args)
    {

        int nota = 49;
        switch (nota)
        {
            case int n when (n >= 90):
                Console.WriteLine("classificação final = A");
                break;
            case int n when (n >= 80):
                Console.WriteLine("classificação final = B");
                break;
            case int n when (n >= 70):
                Console.WriteLine("Clasificação final = C");
                break;
            case int n when (n >= 60):
                Console.WriteLine("Classificação final = D");
                 break;
            default:
                Console.WriteLine("Classificação final = F");
                break;
           


        }
    }
}

