using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class 3numeros
{
	public 3numeros()
	{
		Console.WriteLine("\t\t---Cria um programa que lê tres numeros inteiros e imprime o maior---\t\t");
		Console.Write("Digite o 1° numero: ");
		int num = int.Parse(Console.ReadLine());
		Console.Write("Digite o 2° numero: ");
		int num2 = int.Parse(Console.ReadLine());
		Console.Write("Digite o 3° numero: ");
		int num3 = int.Parse(Console.ReadLine());

		if (num > num2 && > num3)
        {
			Console.Write(" o 1° numero é o maior");
        }
		if else (num2 > num && > num3)
		{
			Console.Write(" o 2° numero é o maior");
        } else
        {
			Console.Write("o 3° numero é o maior")
        }
		Console.Readkey();
	}
}
