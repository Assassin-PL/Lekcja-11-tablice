using System.Xml.Linq;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] ucz ={ 6, 5, 4, 3, 2 };
        string[] lista_naszych_gier = { "minecraft", "fifa", "my summer car", "long drive" };
        //zad 1
        //Stworzyć program konsolowy, w którym należy dodać tablicę 7 elementową,
        //jako elementy należy dodać tytuły ulubionych gier i wyświetlić w konsoli każdy
        //element.
        //Console.WriteLine(lista_naszych_gier[0]);
        //Console.WriteLine(lista_naszych_gier[1]);
        //Console.WriteLine(lista_naszych_gier[2]);
        //Console.WriteLine(lista_naszych_gier[3]);
        for ( int i = 2; i < lista_naszych_gier.Length; i++)
        {
            Console.WriteLine($"nasza gra to: {lista_naszych_gier[i]}");
        }
        Random wylosowanaL = new Random();
        int wyborLiczby =wylosowanaL.Next(0, lista_naszych_gier.Length);
        Console.WriteLine($"nasza wylosowana gra to : {lista_naszych_gier[wyborLiczby]}");
        Console.ReadKey();

        //Ćwiczenie 2
        //Napisać program w konsoli, który znajdzie największą wartość w tablicy i wypisze ją
        //w konsoli.
    }
}