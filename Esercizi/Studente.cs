public class Studente
{
    private string nome;
    private string classe;
    private List<float> voti;
    private DateOnly dataNascita;

    public Studente(string nome, string classe, List<float> Voti,  DateOnly dataNascita)
    {
        this.nome = nome;
        this.classe = classe;
        this.dataNascita = dataNascita;
        this.voti = Voti;
    }

    public void AggiungiVoto(float voto)
    {
        voti.Add(voto);
    }

    public override string ToString()
    {
        float sommaTotale = 0;
        foreach (float v in voti)
        {
            sommaTotale += v;
        }
        float media = sommaTotale / voti.Count;
        return $"Nome: {nome} - Classe: {classe} - Data di nascita: {dataNascita} - Media voti: {media}";
    } 

}