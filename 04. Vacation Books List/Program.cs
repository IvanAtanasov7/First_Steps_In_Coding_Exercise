using System;

namespace _04._Vacation_Books_List
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numberOfPages = int.Parse(Console.ReadLine());
			int pagesPerHour = int.Parse(Console.ReadLine());
			int days = int.Parse(Console.ReadLine());

			int time = numberOfPages / pagesPerHour;
			int hoursPerDay = time / days;
			Console.WriteLine(hoursPerDay);
		}
	}
}
