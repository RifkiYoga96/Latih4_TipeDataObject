namespace Latih4_TipeDataObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var HondaJazz = new Mobil()
            {
                TipeMobil = "Honda Jazz",
                Warna = "Hitam",
                VolumeMesin = 2000,
                BahanBakar = "Pertamax Turbo",
                MaxKecepatan = 180,
                TglProduksi = new DateTime(2024, 1, 2)
            };

            Console.WriteLine($"Tipe Mobil: {HondaJazz.TipeMobil}");
            Console.WriteLine($"Warna: {HondaJazz.Warna}");
            Console.WriteLine($"Volume Mesin: {HondaJazz.VolumeMesin}");
            Console.WriteLine($"Max Kecepatan: {HondaJazz.MaxKecepatan} km/h");
            Console.WriteLine($"Bahan Bakar: {HondaJazz.BahanBakar}");
            Console.WriteLine($"TglProduksi: {HondaJazz.TglProduksi.ToString("dd-MM-yyyy")}");
        }
    
    }
}
