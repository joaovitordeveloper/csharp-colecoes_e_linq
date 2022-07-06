﻿internal class Program
{
  private static void Main(string[] args)
  {
    int[] arrayInteiros = new int[3];

    arrayInteiros[0] = 10;
    arrayInteiros[1] = 20;
    arrayInteiros[2] = 30;

    //arrayInteiros.Length para pegar o total de posições do array
    System.Console.WriteLine("percorrendo o array pelo for");
    for (int i = 0; i < arrayInteiros.Length; i++)
    {
      System.Console.WriteLine(arrayInteiros[i]);
    }

    System.Console.WriteLine("percorrendo o array pelo foreach");
    foreach (int item in arrayInteiros)
    {
      System.Console.WriteLine(item);
    }
  }
}