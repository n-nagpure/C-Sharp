using System;
class GFG{
  public static void Main()
  {
    int[] array = {1, 3, 6, 7, 5, 9 };
    Array.Sort(array);
    Console.WriteLine("Ascending:");
    foreach (int i in array){
        Console.Write(i + " ");
    }
    Array.Reverse(array);
    Console.WriteLine("\n\nDescending:");
    foreach (int i in array)
    {
        Console.Write(i + " ");
    }
  }
}

