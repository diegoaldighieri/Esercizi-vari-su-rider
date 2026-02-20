public class Studente
{
    private string nome;
    private string classe;
    private list<float> voti;
    private DateOnly dataNascita;

    public Studente(string nome, string classe,List<float> Voti,  DateOnly dataNascita)
    {
        this.nome = nome;
        this.classe = classe;
        this.dataNascita = dataNascita;
        this.voti = Voti;
    }

    public override string ToString()
    {
        sommaTotale = 0;
        voti.forEach((v) => sommaTotale += v);
        media = sommaTotale / voti.Count;
        return $"Nome: {nome} - Classe: {classe} - Data di nascita: {dataNascita} - Media voti: {media}";
    } 

}