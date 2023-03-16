using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\t\t---Escreve um programa que lê o nome e as quatro notas de uma disciplina de um aluno " +
            "e ao final escreva o nome do aluno, sua média ese ele foi aprovado, sabendo-se que a média para aprovação é igual
ou superior a 6.0 ")
        string nome;
        double nota1, nota2, nota3, nota4, media;

        Console.WriteLine("Digite o nome do aluno:");
        nome = Console.ReadLine();

        Console.WriteLine("Digite a primeira nota:");
        nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota:");
        nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota:");
        nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quarta nota:");
        nota4 = double.Parse(Console.ReadLine());


        media = (nota1 + nota2 + nota3 + nota4;
Console.WriteLine("Aluno: " + nome);
        Console.WriteLine("Média: " + media.ToString("F1"));

        if (media >= 6.0)
        {
            Console.WriteLine("Situação: Aprovado");
        }

    }
       
else {
            Console.WriteLine("Situação: Reprovado");
        }
    }
}