using System;

namespace _08._Basketball_Equipment
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int tax = int.Parse(Console.ReadLine());

			double shoes = tax * 0.6;
			double equipment = shoes * 0.8;
			double basketballBall = 0.25 * equipment;
			double basketballAccessories = 0.2 * basketballBall;
			double totalPrice = tax + shoes + equipment + basketballBall + basketballAccessories;
			Console.WriteLine(totalPrice);
		}
	}
}
