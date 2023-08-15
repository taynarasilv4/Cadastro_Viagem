using System.Security.Policy;

internal class Pessoa
{
    public string Nome { get; set; }

    public string CPF { get; set; }

    public int DataNascimento { get; set; }

    public int Bagagem { get; set; }

    public Pessoa()
    {

    }

    public Pessoa(string nome, string cpf, int dataNascimento, int bagagem)
    {
        Nome = nome;
        CPF = cpf;
        DataNascimento = dataNascimento;
        Bagagem = bagagem;
    }
    public int Idade(int ano, int mes, int dia)
    {
        int anoAtual = Convert.ToInt32(DateTime.Now.Year);
        int mesAtual = Convert.ToInt32(DateTime.Now.Month);
        int diaAtual = Convert.ToInt32(DateTime.Now.Day);

        int idade = anoAtual - ano;

        if (mesAtual < mes || (mesAtual == mes && diaAtual < dia))
        {
            idade -= 1;
        }
        return idade;
    }
    public int Taxa (int peso)
    {
       return peso * 5;
    }


}




