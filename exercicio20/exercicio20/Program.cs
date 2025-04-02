using System;

public class exercicio_20
{
    public static void Main(string[] args)
    {

        //1 -- quando se faz a conversão de um numero decimal para inteiro, pode ser aredondado ou peder informação//
        //caso 1 converte um numero decimal para inteiro//

        
        double numeroDecimal = 2.94;
        int numeroInteiro = Convert.ToInt32(numeroDecimal);
        Console.WriteLine($" o numero double {numeroDecimal} em Convert para int é: {numeroInteiro}");

        //2 -- quando se faz a conversão de um numero grande para inteiro, pode perder informação/
        //caso 2 converte um numero grande para inteiro//

        
        long numeroGrande = 1000000;
        int numeroInteiroparaConvert = Convert.ToInt32(numeroGrande);
        int inteiroCasting = (int)numeroGrande;
        Console.WriteLine($"o numero long {numeroGrande} em Convert para int  é: {numeroInteiroparaConvert}");
        Console.WriteLine($"o numero long {numeroGrande} em Casting  para int é: {inteiroCasting}");

        
        //3 -- quando se faz a conversão de um caractere para ASCII, o caractere é convertido para o seu valor ASCII//
        //caso 3 converte um caractere para ASCII//

        char caractere = 'B';
        int ascii = Convert.ToInt32(caractere);
        Console.WriteLine($"o caracter {caractere} convert para ascii é: {ascii}");


        //4 -- quando se faz a conversão de um numero fora do intervalo do BYTE para BYTE,
        //caso 4 converte um numero fora do intervalo do BYTE para BYTE//
        int numeroint = 923;
        byte numerobyteCasting = (byte)numeroint;
        byte numerobyteConvert = Convert.ToByte(numeroint);
        Console.WriteLine($"o {numeroint} Casting é: {numerobyteCasting}");
        Console.WriteLine($"o {numeroint} convert é: {numerobyteConvert}");


        //5 -- quando se faz a conversão de um double para float , perde persisão//
        //caso 5 converte um double para float //

        double numerodecimalparafloat = 2.8;
        double numerofloatCasting = (float)(numerodecimalparafloat);
        double numerofloatConvert = Convert.ToSingle(numerodecimalparafloat);
        Console.WriteLine($"o numero double{numerodecimalparafloat} convert  para float é: {numerofloatCasting}");
        Console.WriteLine($"o numero double{numerodecimalparafloat} convert  para float é: {numerofloatConvert}");
    }
}
