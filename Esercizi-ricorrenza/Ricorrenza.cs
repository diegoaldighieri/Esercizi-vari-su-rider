
using System.Reflection.Metadata;

public class Ricorrenza
{
    public void ConteggioRegressivo(int n)
    {
        if (n <= 0) return;
        Console.WriteLine(n);
        ConteggioRegressivo(n - 1);
    }

    public int SommaN(int n)
    {
        if (n == 0) return 0;
        return n + SommaN(n - 1);

    }

    public int Potenza(int basenum, int esponente)
    {
        if (esponente == 0) return 1;
        return basenum * Potenza(basenum, esponente - 1);
    }

    public int ContaCifre(int n)
    {
        if (n == 0) return 0;
        return 1 + ContaCifre(n / 10);
    }

    public int TrovaMassimo(int[] arr, int i)
    {
        if (i == 0) return arr[0];
        int maxResto = TrovaMassimo(arr, i - 1);
        return Math.Max(arr[i], maxResto);
    }

    public bool IsPalindromo(string s)
    {
        s = s.ToLower().Replace(" ", "");
        return IsPalindromo(s, 0, s.Length - 1);
    }

    private bool IsPalindromo(string s, int inizio, int fine)
    {
        if (inizio >= fine) return true;
        if (s[inizio] != s[fine]) return false;
        return IsPalindromo(s, inizio + 1, fine - 1);
    }

    public int MCD(int a, int b)
    {
        if (b == 0) return a;
        return MCD(b, a % b);
    }

    public void Permutazioni(string s)
    {
        
    }
    
}