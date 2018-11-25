using System;
public class Pracownik
{
    public string Nazwisko {get; set; }
    public DateTime DataZatrudnienia {get; set; }

    private decimal _wym;
    public decimal Wynagrodzenie 
    {
        get
        {
            return _wym;
        }
    
         set
        {
            if(value<0) _wym = 0;
            else _wym = value;
        }
    }

    public Pracownik(string nazwisko, DateTime dataZatrudnienia, decimal wynagrodzenie)
    {
        Nazwisko=nazwisko;
        DataZatrudnienia=dataZatrudnienia;
        Wynagrodzenie=wynagrodzenie;
    }
   
    public override string ToString() => $"{Nazwisko}, {DataZatrudnienia}, {Wynagrodzenie}";

    public bool Equals (Pracownik other)
    {
        if(other is null)
            return false;
        return (Nazwisko == other.Nazwisko && 
                DataZatrudnienia == other.DataZatrudnienia &&
                Wynagrodzenie == other.Wynagrodzenie);
    }
}