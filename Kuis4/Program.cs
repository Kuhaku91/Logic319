
//number1();
//number2();
//number3();
number4();
//number5();
//number6();
//number7();


Console.ReadKey();

//static void nomer1()
//{
//    Console.WriteLine(" Tugas Nomer 1 ");
//    Console.WriteLine("===============");
//    Console.WriteLine("=Gaji Karyawan=");

//    Console.WriteLine("Masukan Golongan : ");
//    int gol = new int();

//    List<ClassGaji> gaji = new List<ClassGaji>()
//    {
//        new ClassGaji(){Id = 1, upah = "2000"},
//        new ClassGaji(){Id = 2, upah = "3000"},
//        new ClassGaji(){Id = 3, upah = "4000"},
//        new ClassGaji(){Id = 4, upah = "5000"},

//    };
//}

static void number1()
{
    Console.WriteLine("=== Program Menghitung Gaji Karyawan Per Jam ===");

    // Memasukkan data karyawan
    Console.Write("Masukkan jumlah jam kerja: ");
    int jamKerja = Convert.ToInt32(Console.ReadLine());

    Console.Write("Masukkan golongan (1-4): ");
    int golongan = Convert.ToInt32(Console.ReadLine());

    // Menghitung gaji
    int upahPerJam = 0;
    switch (golongan)
    {
        case 1:
            upahPerJam = 2000;
            break;
        case 2:
            upahPerJam = 3000;
            break;
        case 3:
            upahPerJam = 4000;
            break;
        case 4:
            upahPerJam = 5000;
            break;
        default:
            Console.WriteLine("Golongan yang dimasukkan tidak valid.");
            break;
    }

    if (upahPerJam != 0)
    {
        int totalGaji = jamKerja * upahPerJam;
        Console.WriteLine("Total gaji karyawan: " + totalGaji);
    }

    Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
    Console.ReadKey();
}

static void number2()
{
    Console.WriteLine("Masukkan kalimat:");

    string kalimat = Console.ReadLine();

    // Memisahkan kalimat menjadi kata-kata menggunakan spasi sebagai pemisah
    string[] kataKata = kalimat.Split(' ');

    Console.WriteLine("Hasil:");
    for (int i = 0; i < kataKata.Length; i++)
    {
        Console.WriteLine("Kata " + (i + 1) + ": " + kataKata[i]);
    }

    Console.WriteLine("Total kata adalah: " + kataKata.Length);

    Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
    Console.ReadKey();
}


static void number3()
{
    //Console.WriteLine("Masukkan kata:");

    //    string kata = Console.ReadLine();

    //    string kataBaru = "";

    //    for (int i = 0; i < kata.Length; i++)
    //    {
    //        if (char.IsUpper(kata[i]))
    //        {
    //            kataBaru += "*";
    //        }
    //        else
    //        {
    //            kataBaru += kata[i];
    //        }
    //    }

    //    Console.WriteLine("Hasil: " + kataBaru);

    //    Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
    //    Console.ReadKey();

    Console.WriteLine("Masukkan kata:");

    string kata = Console.ReadLine();

    string kataBaru = "";

    for (int i = 0; i < kata.Length; i++)
    {
        if (char.IsLower(kata[i]))
        {
            kataBaru += "*";
        }
        else
        {
            kataBaru += kata[i];
        }
    }

    Console.WriteLine("Hasil: " + kataBaru);

    Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
    Console.ReadKey();
}

static void number4()
{
    //Console.WriteLine("Masukkan kalimat: ");

    //string kalimat = Console.ReadLine();

    //string[] kataKata = kalimat.Split(' ');

    //string hasil = " * ";
    //foreach (string kata in kataKata)
    //{
    //    string kataBaru = kata.Substring(1, kata.Length - 2); // Mengambil substring mulai dari indeks 1 hingga sebelum indeks terakhir
    //    hasil += kataBaru + " * ";
    //}

    //Console.WriteLine("Hasil: " + hasil.Trim());

    //Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
    //Console.ReadKey();

    Console.Write("Masukkan kalimat yang akan diubah: ");
    string kalimat = Console.ReadLine();

    string kalimatTerubah = UbahAwalAkhirKata(kalimat);
    Console.WriteLine("Kalimat setelah diubah: " + kalimatTerubah);
}

static string UbahAwalAkhirKata(string kalimat)
{
    string[] kata = kalimat.Split(' ');
    for (int i = 0; i < kata.Length; i++)
    {
        if (kata[i].Length > 1)
        {
            char[] karakter = kata[i].ToCharArray();
            karakter[0] = '*';
            karakter[karakter.Length - 1] = '*';
            kata[i] = new string(karakter);
        }
        else if (kata[i].Length == 1)
        {
            kata[i] = "*";
        }
    }
    return string.Join(" ", kata);
}


static void number5()
{
    Console.WriteLine("Masukkan kalimat:");

    string kalimat = Console.ReadLine();

    string[] kataKata = kalimat.Split(' ');

    string hasil = "";
    foreach (string kata in kataKata)
    {
        string kataBaru = kata.Substring(1, kata.Length - 2); // Mengambil substring mulai dari indeks 1 hingga sebelum indeks terakhir
        hasil += kataBaru + " ";
    }

    Console.WriteLine("Hasil: " + hasil.Trim());

    Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
    Console.ReadKey();
}




static void number7()
{
    Console.Write("Masukkan jumlah bilangan Fibonacci yang ingin ditampilkan: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Deret Fibonacci:");
    for (int i = 1; i <= n; i++)
    {
        Console.Write(FibonacciNumber(i));
        if (i != n)
        {
            Console.Write(", ");
        }
    }
}

static int FibonacciNumber(int n)
{
    if (n <= 2)
    {
        return 1;
    }
    else
    {
        int a = 1;
        int b = 1;
        int result = 0;
        for (int i = 3; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }
        return result;
    }
}