using System;
using System.Collections.Generic;
using System.ComponentModel;
public class exercicio19
{
    public static void Main(string[] args)
    {
        //iplementar um dicionario

        Dictionary<string, string> listatelefonica = new Dictionary<string, string>();

        // Apresentar o menu
        Console.WriteLine("1..... Adicionar contacto");
        Console.WriteLine("2..... pesquisar contacto");
        Console.WriteLine("3..... remover contacto");
        Console.WriteLine("4..... sair");

        // Pedir ao utilizador que escolha uma opção

        Console.WriteLine("Escolha uma opção: ");
        //variavel opcao
        String opcao = Console.ReadLine();
        do
        {
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Introduza o nome do contacto: ");
                    String nome = Console.ReadLine();
                    Console.WriteLine("Introduza o número do contacto: ");
                    String Contacto = Console.ReadLine();
                    listatelefonica.Add(nome, Contacto);
                    Console.WriteLine("Contacto adicionado com sucesso");
                    break;

                case "2":
                    //Adicionar contacto e numero para que o programa possa procurar
                    listatelefonica.Add("alice", "123456789");
                    Console.WriteLine("Introduza o nome do contacto que deseja procurar: ");

                    //nomepesquisa é a variavel que o utilizador vai introduzir para procurar p contacto
                    String nomepesquisa = Console.ReadLine();
                    //contains.key é usado para identificar algo que esteja dentro do dicionario
                    if (listatelefonica.ContainsKey(nomepesquisa))
                    {
                        Console.WriteLine("Nome: " + nomepesquisa + "\nContacto: " + listatelefonica[nomepesquisa]);
                    }
                    else
                    {
                        Console.WriteLine("O contacto " + nomepesquisa + " não existe");
                    }
                    break;
                case "3":
                    //Adicionar contacto e numero para que o programa possa remove-lo
                    listatelefonica.Add("alice", "123456789");
                    Console.WriteLine("Introduza o contacto que deseja remover: ");
                    nomepesquisa = Console.ReadLine();
                    if (listatelefonica.ContainsKey(nomepesquisa))
                    {
                        listatelefonica.Remove(nomepesquisa);
                        Console.WriteLine("Contacto removido com sucesso");
                    }
                    else
                    {
                        Console.WriteLine("O contacto " + nomepesquisa + " não existe");
                    }
                    break;
                default:
                    //caso o utilizador escolha a opção 4, ou seja, nenhuma das 3 opções anteriores, o programa vai sair
                    Console.WriteLine("saindo. . . . . ");
                    break;
            }
        }
        //enquanto a opção for diferente, menos de 4, o programa vai continuar a correr
        while (opcao != "4");
    }
}
