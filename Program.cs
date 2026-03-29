class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
﻿class DataGeneric<T>
{
    private T data;
    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        //memanggil class HaloGeneric
        HaloGeneric halo = new HaloGeneric();

        Console.Write("Masukkan nama kamu: ");
        //meminta input nama
        string namaInput = Console.ReadLine();
        halo.SapaUser<string>(namaInput);

        //menyimpan nim
        DataGeneric<string> dataNIM = new DataGeneric<string>("103022400147");
        dataNIM.PrintData();
    }
}