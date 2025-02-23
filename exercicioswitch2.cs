using System;

public class exercicio7
{
    static void Main(string[] args)
    {

        int dias = 7;
        switch (dias)
        {
            case 1:
                Console.WriteLine("domingo");
                break;
            case 2:
                Console.WriteLine("segunda");
                break;
            case 3:
                Console.WriteLine("terça");
                break;
            case 4:
                Console.WriteLine("quarta");
                break;
            case 5:
                Console.WriteLine("quinta");
                break;
            case 6:
                Console.WriteLine("sexta");
                break;
            default:
                Console.WriteLine("sabado");
                break;
        }
    }
}

