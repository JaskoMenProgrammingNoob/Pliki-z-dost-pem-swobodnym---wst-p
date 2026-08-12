using System.IO;
class Plik_swobodny
{
    FileStream F;
    char[] alfabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', };
    public void zapisz_i_odczytaj_dane()
    {
        F = new FileStream("alfabet.txt", FileMode.Create);
        for(int i = 0; i < alfabet.Length; i++)
        {
            F.WriteByte((byte)alfabet[i]);
        }
        F.Close();

        F = new FileStream("alfabet.txt", FileMode.Open);
         for (int i = 0; i < alfabet.Length; i++)
        {
            F.Seek(i, SeekOrigin.Begin);
            char ch = (char)F.ReadByte();
            Console.Write(ch);
        }

        F.Close();
    }
    
        
    




    static void Main(string[] args)
    {
        Plik_swobodny p = new Plik_swobodny();
        p.zapisz_i_odczytaj_dane();
    }
}