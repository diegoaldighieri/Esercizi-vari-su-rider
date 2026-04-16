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
        return (n == 0) ? 0 : n + SommaN(n - 1);
    }

    public int Potenza(int basenum, int esponente)
    {
        return (esponente == 0) ? 1 : basenum * Potenza(basenum, esponente - 1);
    }

    public int ContaCifre(int n)
    {
        return (n == 0) ? 0 : 1 + ContaCifre(n / 10);
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
        return (b == 0) ? a :  MCD(b, a % b);
    }

    public void Permutazioni(string s, string corrente = "")
    {
        if (s.Length == 0)
        {
            Console.WriteLine(corrente);
            return;
        }

        for (int i = 0; i < s.Length; i++)
        {
            string rimanente = s.Remove(i, 1);
            Permutazioni(rimanente, corrente + s[i]);
        }
    }

    public void Hanoi(int n, string daPiolo, string aPiolo, string appoggioPiolo)
    {
        if (n == 0) return;
        Hanoi(n - 1, daPiolo, appoggioPiolo, aPiolo);
        Console.WriteLine($"Sposta disco {n} da {daPiolo} a {aPiolo}");
        Hanoi(n - 1, appoggioPiolo, aPiolo, daPiolo);
    }
    
}