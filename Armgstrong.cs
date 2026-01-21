using System;
namespace Practice
{
	class Armgstrong
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter a number=");
			int num = int.Parse(Console.ReadLine());
			int  rem, sum = 0;
			int num1 = num;
			while (num1 > 0)
			{
				rem = num1 % 10;
				sum = sum + (rem * rem * rem);
				num1 /= 10;
			}
			if (num == sum)
			{
				Console.WriteLine(num + " is Palindrome number");
			}
			else
			{
				Console.WriteLine(num+" is not Palindrome number");
			}
		}
	}
}
