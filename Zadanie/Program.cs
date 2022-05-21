using Zadanie;

Console.WriteLine("Książka");
var ksiazka = new Ksiazka(5, 10.8M);

var zysk = ksiazka.Zysk();

Console.WriteLine($"Zysk: {zysk}");
Console.WriteLine($"{ksiazka.ToString()}");

Console.WriteLine("Księgarnia");
var ksiegarnia = new Księgarnia();

zysk = ksiegarnia.Zysk();

Console.WriteLine($"Zysk: {zysk}");
ksiegarnia.Wypisz();