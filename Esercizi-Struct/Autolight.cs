public struct AutoLight
{
   public string Modello { get; init; }
   public int Cilindrata { get; init; }

    public AutoLight(string modello, int cilindrata)
    {
        Modello = modello;
        Cilindrata = cilindrata;
    }

}