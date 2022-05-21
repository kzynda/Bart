namespace Zadanie;

public class Ksiazka
{
	public Ksiazka(int naklad, decimal cenaEgzemplarza)
	{
		_naklad = naklad;
		_cenaEgzemplarza = cenaEgzemplarza;
	}

	private readonly int _naklad;

	private readonly decimal _cenaEgzemplarza;

	public decimal Zysk()
	{
		return _naklad * _cenaEgzemplarza;
	}

	public override string ToString()
	{
		return $"Nakład: {_naklad} sztuk w cenie {_cenaEgzemplarza} za sztukę";
	}
}