using System;
using System.Numerics;
namespace soma
{ 
    public class ex2
    {
        static void Main(string[] args) {
            int soma = 0;
            for (int contador = 1; contador <= 50; contador++)
            {
                if(contador % 2 != 0)
                {
                    soma = soma + contador;
                }
            } 
            Console.WriteLine("Total numeros impares="+soma);
        } 
    }

}

