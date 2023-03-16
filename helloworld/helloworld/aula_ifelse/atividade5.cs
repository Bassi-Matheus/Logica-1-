using System;

public class Class1
{
	public Class1()
	{
		double salario;


		Console.WriteLine("\t\t---O algoritmo lê o salario atual e calcula e exibe o salário reajustado de acordo com a " +
			"seguinte regra: Salário até 1500, reajustede 23%; Salários maiores que 1500, reajuste de 18%---\t\t");



		Console.WriteLine("Digite seu salario atual");
		salario = double.Parse(Console.ReadLine());
		if (salario =< 1500.00)
        {
			Console.Write("seu salario é de: " + (1500+(1500*0.23));
        }
        else
        {
			Console.Write("seu salario é de: " + (1500 + (1500 * 0.18));
		}

	}
}
