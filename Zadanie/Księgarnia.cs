namespace Zadanie;

public class Księgarnia
{
	public Księgarnia()
	{
		_magazyn = new[]
		{
			new Ksiazka(5, 10M),
			new Ksiazka(10, 20M)
		};
	}

	private Ksiazka[] _magazyn;

	public void Wypisz()
	{
		foreach (var ksiazka in _magazyn)
		{
			Console.WriteLine($"{ksiazka.ToString()}");
		}
	}

	public decimal Zysk()
	{
		decimal suma = 0;
		
		foreach (var ksiazka in _magazyn)
		{
			suma += ksiazka.Zysk();
		}

		return suma;
	}
}