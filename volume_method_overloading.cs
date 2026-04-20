using System;

class VolumeCalculator
{
	public double Volume(double length, double width, double height)
	{
		return length * width * height;
	}
	public double Volume(double radius, double height)
	{
		return Math.PI * radius * radius * height;
	}
	public double Volume(double side)
	{
		return side * side * side;
	}
}
class Program
{
	static void Main()
	{
		VolumeCalculator calc = new VolumeCalculator();

		Console.WriteLine($"Cube Volume: {calc.Volume(5, 6, 6)}");
		Console.WriteLine($"Cylinder Volume: {calc.Volume(3, 4)}");
		Console.WriteLine($"Square Volume: {calc.Volume(5)}");
	}
}
