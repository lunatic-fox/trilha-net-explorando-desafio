namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = ToUpperFirstLetter(nome);
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = ToUpperFirstLetter(nome);
        Sobrenome = string.Join(' ', sobrenome.Split(' ').Select(ToUpperFirstLetter));
    }

    private string ToUpperFirstLetter(string str) => $"{str[0].ToString().ToUpper()}{str[1..]}";

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}";
}
