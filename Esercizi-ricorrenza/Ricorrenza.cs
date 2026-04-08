using System;

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

    



}
