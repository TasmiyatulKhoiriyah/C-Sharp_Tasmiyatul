using System;

class Program
{
    static void Main()
    {
        bool ulang = true;

        while (ulang)
        {
        // Menampilkan menu pilihan
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("--------->>> APLIKASI KONVERSI SUHU <<<---------");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("Menu Konversi Suhu:");
        Console.WriteLine("1. Celsius ke Fahrenheit");
        Console.WriteLine("2. Celsius ke Kelvin");
        Console.WriteLine("3. Celsius ke Reamur");
        Console.WriteLine("4. Exit");

        // Meminta pengguna untuk memilih menu
        Console.WriteLine("Pilih menu (1-4): ");
        Console.WriteLine("------------------------------------------------");
        int pilihan = Convert.ToInt32(Console.ReadLine());
        
        double suhuOutput = 0;

        // Melakukan konversi berdasarkan pilihan pengguna
        switch (pilihan)
        {
        case 1:
            suhuOutput = CelsiusToFahrenheit();
            break;
        case 2:
            suhuOutput = CelsiusToKelvin();
            break;
        case 3:
            suhuOutput = CelsiusToReamur();
            break;

        default:
            Console.WriteLine("Pilihan tidak valid.");
            return;
        }
Console.WriteLine("------------------------------------------------");
Console.WriteLine("--------->>> HASIL KONVERSI SUHU <<<---------");
Console.WriteLine("------------------------------------------------");
// Menampilkan hasil konversi
Console.WriteLine($"Hasil konversi: {suhuOutput:F2}");
Console.WriteLine("------------------------------------------------");
// Meminta pengguna apakah ingin mengulang
Console.Write("Ingin mengulang? (y/n): ");
string jawaban = Console.ReadLine().ToLower();
ulang = (jawaban == "y");

Console.Clear(); // Membersihkan layar untuk iterasi berikutnya
}
}

// Fungsi konversi suhu
static double CelsiusToFahrenheit()
{
    Console.Write("Masukkan suhu: ");
    double suhuInput = Convert.ToDouble(Console.ReadLine());
    return ((suhuInput * 9 / 5) + 32);
}

static double CelsiusToKelvin()
{
    Console.Write("Masukkan suhu: ");
    double suhuInput = Convert.ToDouble(Console.ReadLine());
    return (suhuInput + 273.15);
}

static double CelsiusToReamur()
{
    Console.Write("Masukkan suhu: ");
    double suhuInput = Convert.ToDouble(Console.ReadLine());
    return (suhuInput * 4 / 5);
}
}
