public class Ricorrenza
{
    public int ConteggioRegressivo(int n)
    {
        if (n == 0) return 0;
        return 1 + ConteggioRegressivo(n - 1);
    }

    public int SommaN(int n)
    {
        if (n == 0) return 0;
        return n + SommaN(n - 1);

    }

    public int Potenza(int base, int esponente)
    {
        if (esponente == 0) return 1;
        return base * Potenza(base, esponente - 1);
    }

    public int ContaCifre(int n)
    {
        if (n == 0) return 0;
        return 1 + ContaCifre(n / 10);
    }

    



}
