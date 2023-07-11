using System;

namespace _05._Supplies_for_School
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			int pen = int.Parse(Console.ReadLine());
			int markers = int.Parse(Console.ReadLine());
			int cleaningPreparation = int.Parse(Console.ReadLine());
			int percent = int.Parse(Console.ReadLine());

			double pricePen = pen * 5.80;
			double priceMarkers = markers * 7.20;
			double priceCleaningPreparation = cleaningPreparation * 1.20;
			double sum = pricePen + priceMarkers + priceCleaningPreparation;
			double totalPrice = sum - (sum * percent / 100);
			Console.WriteLine(totalPrice);
		}
	}
}
