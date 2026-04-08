var ric = new Ricorrenza();

Test("ConteggioRegressivo(5)", ric.ConteggioRegressivo(5), 5);
Test("SommaN(5)", ric.SommaN(5), 15);
Test("Potenza(2, 10)", ric.Potenza(2, 10), 1024);
Test("Potenza(5, 0)", ric.Potenza(5, 0), 1);
Test("ContaCifre(123)", ric.ContaCifre(123), 3);

void Test(string name, int actual, int expected)
{
    Console.WriteLine($"{name}: {actual} {(actual == expected ? "OK" : $"ERRORE (atteso {expected})")} ");
}
