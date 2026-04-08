using System;

var ric = new Ricorrenza();

Console.WriteLine("Conteggio regressivo da 5 a 1:");
ric.ConteggioRegressivo(5);
Console.WriteLine();

Test("SommaN(5)", ric.SommaN(5), 15);
Test("Potenza(2, 10)", ric.Potenza(2, 10), 1024);
Test("Potenza(5, 0)", ric.Potenza(5, 0), 1);
Test("ContaCifre(123)", ric.ContaCifre(123), 3);

void Test(string name, int actual, int expected)
{
    Console.WriteLine($"{name}: {actual} {(actual == expected ? "OK" : $"ERRORE (atteso {expected})")} ");
}
