public class Voo
{

    public bool[] cadeiras = new bool[99];

    public int ProximoLivre()
    {
        for (int i = 0; i < this.cadeiras.Length; i++)
        {
            if (this.cadeiras[i] == false)
            {
                return i + 1;

            }
        }
        Console.WriteLine("Não ha cadeiras suficientes");
        return -1;
    }

   

}
