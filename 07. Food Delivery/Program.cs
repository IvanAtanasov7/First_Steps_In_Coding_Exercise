using System;

namespace _07._Food_Delivery
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int chickenMenu = int.Parse(Console.ReadLine());
			int fishMenu = int.Parse(Console.ReadLine());
			int veganMenu = int.Parse(Console.ReadLine());

			double priceChickenMenu = chickenMenu * 10.35;
			double priceFishMenu = fishMenu * 12.40;
			double priceVeganMenu = veganMenu * 8.15;
			double sumMenu = priceChickenMenu + priceFishMenu + priceVeganMenu;
			double dessert = sumMenu * 0.2;
			double priceDelivery = 2.50;
			double totalPrice = sumMenu + dessert + priceDelivery;
			Console.WriteLine(totalPrice);
		}
	}
}
