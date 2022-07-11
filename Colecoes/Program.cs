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
    int[] arrayCopia = new int[10];

    string[] arrayString = op.ConverterParaArrayString(array);

    // int valorProcurado = 1;

    // System.Console.WriteLine($"Capacidade atal do array: {array.Length}");

    // op.RedimensionarArray(ref array, array.Length * 2);

    // System.Console.WriteLine($"Capacidade atal do array após redimensionar: {array.Length}");

    // int indice = op.ObterIndice(array, valorProcurado);

    // if (indice > -1)
    // {
    //   System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
    // }
    // else
    // {
    //   System.Console.WriteLine($"O indice não foi encontrado");
    // }

    // int valorAchado = op.ObterValor(array, valorProcurado);

    // if (valorAchado > 0)
    // {
    //   System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
    // }
    // else
    // {
    //   System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
    // }

    // bool todosMaiorQue = op.todosMaiorQue(array, valorProcurado);

    // if(todosMaiorQue)
    // {
    //   System.Console.WriteLine("Todos os valores são maior que: {0}", valorProcurado);
    // }
    // else
    // {
    //   System.Console.WriteLine("Nem todos os vlores são maior que: {0}", valorProcurado);
    // }

    // bool Existe = op.Existe(array, valorProcurado);

    // if(Existe)
    // {
    //   System.Console.WriteLine("Valor encontrado: {0}", valorProcurado);
    // }
    // else
    // {
    //   System.Console.WriteLine("Valor não encontrado: {0}", valorProcurado);
    // }

    /* System.Console.WriteLine("array original");
    op.ImprimirArray(array); */

    //metodo OrdenarBubbleSort
    //op.OrdenarBubbleSort(ref array);

    //metodo Ordenar usando a classe Array
    //op.Ordenar(ref array);

    // System.Console.WriteLine("array antes da copia");
    // op.ImprimirArray(arrayCopia);

    // op.Copiar(ref array, ref arrayCopia);

    // System.Console.WriteLine("array ddepois de ser copiado");
    // op.ImprimirArray(arrayCopia);
  }
}