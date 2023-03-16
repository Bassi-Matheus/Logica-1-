using System;

public class Class1
{
	public Class1()
	{
		Console.WriteLine("\t\t---Escreve um programa que entra com o nome de duas pessoas e " +
            "exibe qual o maior nome e sua quantidade de letras---\t\t")

			Console.WriteLine("Digite a String: ")
			string str1 = Console.ReadLine();
		int length = str1.Length;
		Console.WriteLine("Digite a 2° String: ")
			string str2 = Console.ReadLine();
		int length = str2.Length;

		if (str1 > str2)
			Console.Write("a primeira string possui mais caracteres!");
	}
	else
	{
			 Console.Write("a segunda string possui mais caracteres!");
	}
}
