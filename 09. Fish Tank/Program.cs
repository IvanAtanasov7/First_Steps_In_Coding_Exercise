using System;

namespace _09._Fish_Tank
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int length = int.Parse(Console.ReadLine());
			int width = int.Parse(Console.ReadLine());
			int height = int.Parse(Console.ReadLine());
			double percent = double.Parse(Console.ReadLine());

			double volumeOfTheAquarium = length * width * height;
			double volumeInLiters = volumeOfTheAquarium * 0.001;
			double occupiedSpace = percent / 100;
			double neededLiters = volumeInLiters * (1 - occupiedSpace);
			Console.WriteLine(neededLiters);
		}
	}
}
