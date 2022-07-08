using System;
using Colecoes.Helper;

namespace Colecoes;
internal class Program
{
  private static void Main(string[] args)
  {
    /* int[] arrayInteiros = new int[3];

    arrayInteiros[0] = 10;
    arrayInteiros[1] = 20;
    arrayInteiros[2] = 30; */

    //arrayInteiros.Length para pegar o total de posições do array
    /* System.Console.WriteLine("percorrendo o array pelo for");
    for (int i = 0; i < arrayInteiros.Length; i++)
    {
      System.Console.WriteLine(arrayInteiros[i]);
    }

    System.Console.WriteLine("percorrendo o array pelo foreach");
    foreach (int item in arrayInteiros)
    {
      System.Console.WriteLine(item);
    } */

    //array multidimensional

    /* int[,] matriz = new int[4, 2]
    {
        {8,8},
        {9,11},
        {10,10},
        {11,9}
    };

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
      for (int j = 0; j < matriz.GetLength(1); j++)
      {
        System.Console.WriteLine(matriz[i,j]);
      }
    } */

    OperacoesArray op = new OperacoesArray();

    int[] array = new int[5]{10,20,80,9,1};

    System.Console.WriteLine("array original");
    op.ImprimirArray(array);

    //metodo OrdenarBubbleSort
    //op.OrdenarBubbleSort(ref array);

    //metodo Ordenar usando a classe Array
    op.Ordenar(ref array);

    System.Console.WriteLine("array ordenado");
    op.ImprimirArray(array);
    
  }
}