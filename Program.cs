using System.ComponentModel.DataAnnotations;

public class Penjumlahan
{
    public static void JumlahTigaAngka<T>(T angkaPertama, T angkaKedua, T angkaKetiga) where T: struct
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

        Console.WriteLine();
        SimpleDataBase<long> database = new SimpleDataBase<long>();
        database.AddnewData(13);
        database.AddnewData(02);
        database.AddnewData(22);
        database.PrintAllData();
    }
}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddnewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        int i = 0;
        int j = i + 1;
        foreach (T data in storedData)
        {
            Console.WriteLine("Data " + j + " berisi: " + storedData[i] + ", yang disimpan pada waktu " + inputDates[i]);
            i++;
            j++;
        }
    }
}
