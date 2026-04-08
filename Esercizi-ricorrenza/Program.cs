using System;

var ric = new Ricorrenza();

Console.WriteLine("Conteggio regressivo da 5 a 1:");
ric.ConteggioRegressivo(5);
Console.WriteLine();

Test("SommaN(5)", ric.SommaN(5));
Test("Potenza(2, 10)", ric.Potenza(2, 10));
Test("Potenza(5, 0)", ric.Potenza(5, 0));
Test("ContaCifre(123)", ric.ContaCifre(123));
Test("TrovaMassimo([1, 5, 3, 9, 2], 4)", ric.TrovaMassimo(new int[] { 1, 5, 3, 9, 2 }, 4));

void Test(string name, int risultato)
{
    Console.WriteLine($"{name}: {risultato} ");
}