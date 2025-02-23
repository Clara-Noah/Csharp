using System;
namespace numeros
{
    internal class Program
    {
        //exercicio1
        static void Main(string[] arg)
        {
            
            for (int contador = 0; contador <= 20; contador++)   
            {
                if(contador % 2 == 0)
                    { 
                    Console.WriteLine(contador);
                    }
            }

        }
    }
}