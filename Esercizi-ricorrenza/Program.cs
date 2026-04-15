
var ric = new Ricorrenza();

Console.WriteLine("Conteggio regressivo da 5 a 1:");
ric.ConteggioRegressivo(5);
Console.WriteLine();

Test("SommaN(5)", ric.SommaN(5));
Test("Potenza(2, 10)", ric.Potenza(2, 10));
Test("Potenza(5, 0)", ric.Potenza(5, 0));
Test("ContaCifre(60)", ric.ContaCifre(60));
Test("TrovaMassimo([1, 5, 3, 9, 2], 4)", ric.TrovaMassimo(new int[] { 1, 5, 3, 9, 2 }, 4));
Test("MCD(12, 8)", ric.MCD(12, 8));

TestBool("IsPalindromo(\"radar\")", ric.IsPalindromo("radar"));
TestBool("IsPalindromo(\"hello\")", ric.IsPalindromo("hello"));
TestBool("IsPalindromo(\"A man a plan a canal Panama\")", ric.IsPalindromo("A man a plan a canal Panama"));

Console.WriteLine("Conteggio permutazione");
ric.Permutazioni("aaa");


void Test(string name, int risultato)
{
    Console.WriteLine($"{name}: {risultato} ");
}

void TestBool(string name, bool risultato)
{
    Console.WriteLine($"{name}: {risultato} ");
}