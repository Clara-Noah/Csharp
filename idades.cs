using System;
using System.ComponentModel.Design;

public class Program
    {
    static void Main(string[] args)
    {
        //Cria um algoritemo que descubra se o utilizador é ma criança, adolescente ou adulto
        int idade = 19;
        bool isSolteiro = false;

        if (idade < 18)
        {
            Console.WriteLine("És menor de idade");
        }
        else if (idade >= 18 && idade < 65 && isSolteiro)
        {
           Console.WriteLine("É adulto e solteiro");
        }
        else if (idade >= 18 && idade < 65 && !isSolteiro)
        { 
         Console.WriteLine("É adulto e casado");
        }
        else
        {
            Console.WriteLine("És sénior");
        }

      }
    }

