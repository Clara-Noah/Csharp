using System;
namespace Project
    {
    public class N4
    {
        static void Main(string[] arg)
        {
            int x = 1;
            int z = 2;
            int w = 3;
            int y = 1;

            if(x == z && z == x && x == w && w == y) 
            {
                Console.WriteLine("os numeros são iguai");
            }
            else 
            {
                Console.WriteLine("os numeros não são iguais");
            }
        
        }
    }
}
