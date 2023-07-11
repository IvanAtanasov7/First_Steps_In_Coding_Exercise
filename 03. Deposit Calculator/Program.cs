using System;

namespace _03._Deposit_Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double deposit = double.Parse(Console.ReadLine());
			int termOfDeposit = int.Parse(Console.ReadLine());
			double percent = double.Parse(Console.ReadLine());

			double sum = deposit + termOfDeposit * ((deposit * percent / 100) / 12);
			Console.WriteLine(sum);

		}
	}
}
