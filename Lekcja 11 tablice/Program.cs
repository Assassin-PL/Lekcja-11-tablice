using System.Xml.Linq;
using System;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        //Ćwiczenie 2
        //Napisać program w konsoli, który znajdzie największą wartość w tablicy i wypisze ją
        //w konsoli.
        // Program daniela: 
        int[] numery = { 5, 3, 9, 2, 8, 1, 7, 6 };

        int MaksymalnaWartosc = numery[0];

        for (int i = 0; i < numery.Length; i++)
        {
            if (numery[i] > MaksymalnaWartosc)
            {
                MaksymalnaWartosc = numery[i];
            }
        }
        Console.WriteLine($"Największa wartość w tablicy to: {MaksymalnaWartosc}");

        string[] lodowka = { "mleko", "ser", "szynka", "pomidor", "jajko", "salata" };
        // petla for each:
        foreach (string produkt in lodowka)
        {
            Console.WriteLine($"jednen z naszych produktow w lodowce to: {produkt}");            
        }
        //Ćwiczenie 3
        //Zmodyfikować kod ćwiczenia nr 2, tak by wykorzystywał pętlę foreach.
        Console.WriteLine("znajdz najwieksza wartosc z     tablicy przy pomocy petli foreach");
        foreach (int liczba in numery)
        {
            if (liczba > MaksymalnaWartosc)
            {
                MaksymalnaWartosc = liczba;
            }
        }
        Console.WriteLine($"Najsza najwieksz liczba to : {MaksymalnaWartosc}");
        //Ćwiczenie 4
        //Napisać program konsolowy, który symuluje system rezerwacji biletów do kina.
        //Należy stworzyć repertuar, pobrać od klienta dane osobowe(wybrany film, godzinę seansu, imię, nazwisko, telefon, mail oraz liczbę biletów) a następnie wyświetlić
        //podsumowanie rezerwacji.
        string[] filmy = { };
        Console.ReadKey();
    }
}