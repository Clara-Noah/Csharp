using System;
using System.Collections.Generic;
public class exercicio19
{
    public static void Main(string[] args)
    {
        //implementar um dicionario

        Dictionary<string, int> listatelefonica = new Dictionary<string, int>();
        string opcao;
        int opcaoInt;
        do
        {
            // Apresentar o menu
            Console.WriteLine("1..... Adicionar contacto");
            Console.WriteLine("2..... pesquisar contacto");
            Console.WriteLine("3..... remover contacto");
            Console.WriteLine("4..... sair");

            // Pedir ao utilizador que escolha uma opção

            Console.WriteLine("Escolha uma opção: ");
            //variavel opcao
            opcao = Console.ReadLine();
            opcaoInt = Convert.ToInt32(opcao);
            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Introduza o nome do contacto: ");
                    String nome = Console.ReadLine();
                    Console.WriteLine("Introduza o número do contacto: ");
                    String contacto = Console.ReadLine();
                    int contactoInt = Convert.ToInt32(contacto);
                    listatelefonica.Add(nome, contactoInt);
                    Console.WriteLine("Contacto adicionado com sucesso");
                    break;
                case "2":
                    Console.WriteLine("Introduza o nome do contacto que deseja procurar: ");

                    //nomepesquisa é a variavel que o utilizador vai introduzir para procurar o contacto
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
                case "4":
                    //caso o utilizador escolha a opção 4, ou seja, nenhuma das 3 opções anteriores, o programa vai sair
                    Console.WriteLine("A sair. . . . . ");
                    break;

                //se nenhuma das 4 opções for escolhida, esta opção será acionada automaticamente
                default:
                    Console.WriteLine("opção invalida");
                    break;
            }
        } while (opcaoInt != 4);
    }
}
