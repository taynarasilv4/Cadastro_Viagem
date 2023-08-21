using Newtonsoft.Json;
using System.Security.Policy;

internal class Pessoa
{
    public string Nome { get; set; }

    public string CPF { get; set; }
    public string Telefone { get; set; }    
    public int Idade { get; set; }

    public bool JsonSerializar(Pessoa pessoa, string path)
    {
        var strJson = JsonConvert.SerializeObject(pessoa);
        return SaveFilePessoa(strJson, path);


    }
    public bool SaveFilePessoa(string strJson, string path)
    {
        try
        {
            using (StreamWriter sr = new StreamWriter(path))
            {
                sr.WriteLine(strJson);


            }
            return true;
        }
        catch (Exception at)
        {
            MessageBox.Show("Falha " + at.Message);
            return false;
        }
        
    }
    public static Pessoa JsonDesserializar(string Json)
    {
        return JsonConvert.DeserializeObject<Pessoa>(Json);
    }
    public Pessoa()
    {

    }

    public Pessoa(string nome, string cpf, int idade, string telefone)
    {
        Nome = nome;
        CPF = cpf;
        Idade = idade;
        Telefone = telefone;
       
    }
    public int CalculoIdade(int ano, int mes, int dia)
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




