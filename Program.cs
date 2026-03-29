class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo user " + user);
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
    }
}