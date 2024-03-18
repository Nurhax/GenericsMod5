public class Penjumlahan
{
    public static void JumlahTigaAngka<T>(T angkaPertama, T angkaKedua, T angkaKetiga)
    {
        dynamic hasil1 = angkaPertama;
        dynamic hasil2 = angkaKedua;
        dynamic hasil3 = angkaKetiga;
        dynamic total = hasil1 + hasil2 + hasil3;
        
        Console.WriteLine("Hasil penjumlahan 2 digit NIM dari depan :" + total);
    }

}

public class Program
{
    public static void Main(string[] args)
    {
        //NIM = 1302223050;
        Penjumlahan.JumlahTigaAngka<long>(13,02,22);
    }
}
