using System;

namespace Tema4_Iteracion
{
	class Program
	{
		static void Main(string[] args)
		{
			string  VOpcion = "";int num = 0, num2f = 0;

			Console.WriteLine("Elige cual funcion desea usar\n\n1-Sumatoria\n2-Factorial\n3-Máximo común divisor\n\n inserte el numero correspondiente  ");
			VOpcion=Console.ReadLine();

			switch (VOpcion)
			{
				case "1":
					Console.Clear();
					Console.WriteLine("Inserta un numero para realizar la sumatoria");
					num = int.Parse(Console.ReadLine());

					Console.Clear();
					Console.WriteLine(Sumatoria(num)); 

					break;
				case "2":
					Console.Clear();
					Console.WriteLine("Inserta un numero para obtener el factorial");
					num = int.Parse(Console.ReadLine());

					Console.Clear();
					Console.WriteLine(Factorial(num));
					break;
				case "3":
					Console.Clear();
					Console.WriteLine("Inserte el primer numero para Encontrar el MCD por el algoritmo de Euclides");
					num = int.Parse(Console.ReadLine());

					Console.Clear();
					Console.WriteLine("Inserte el Segundo numero para Encontrar el MCD por el algoritmo de Euclides");
					num2f = int.Parse(Console.ReadLine());

					Console.Clear();
					Console.WriteLine(MCD(num,num2f));

					break;
			}
		}
		static int Sumatoria(int num)
		{
			int sum = 0;
			for (int i = 1; i < num+1; i++)
			{
				sum = sum + i;
				
			}


			return sum;


		}
		static int Factorial(int num)
		{
			int fac = num;
			for (int i = 1; i < num ; i++)
			{
				fac = fac * i;

			}
			return fac;

		}
		static int MCD(int a, int b)
		{
			int R = 0;
			do 
			{
				R = b;  
				b = a % b;      
				a = R;  
			}
			while(b != 0);

			return R;
		}
			
	}
}
