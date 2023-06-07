
//number1();
//number2();
//number3();
//number4();
//number5();
//number6();
//number7();
number8();
//kalkulator();
//cobaprinthurufR();
//gambarrumah();



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
    //Console.Write("Masukkan jumlah bilangan Fibonacci yang ingin ditampilkan: ");
    //int n = Convert.ToInt32(Console.ReadLine());

    //Console.WriteLine("Deret Fibonacci:");
    //for (int i = 1; i <= n; i++)
    //{
    //    Console.Write(FibonacciNumber(i));
    //    if (i != n)
    //    {
    //        Console.Write(" ");
    //    }
    //}
    //Console.Write("Masukkan jumlah baris: ");
    //int jumlahBaris = Convert.ToInt32(Console.ReadLine());

    //Console.Write("Masukkan angka awal: ");
    //int angkaAwal = Convert.ToInt32(Console.ReadLine());

    //Console.Write("Masukkan angka kedua: ");
    //int angkaKedua = Convert.ToInt32(Console.ReadLine());

    //Console.WriteLine();

    //Console.Write(angkaAwal + " " + angkaKedua + " ");

    //for (int i = 2; i < jumlahBaris; i++)
    //{
    //    int angkaSaatIni = angkaAwal + angkaKedua;
    //    Console.Write(angkaSaatIni + " ");
    //    angkaAwal = angkaKedua;
    //    angkaKedua = angkaSaatIni;
    //}

    //Console.Write("Masukkan jumlah angka dalam deret Fibonacci: ");
    //int jumlahAngka = Convert.ToInt32(Console.ReadLine());

    //Console.Write("Masukkan angka awal: ");
    //int angkaAwal = Convert.ToInt32(Console.ReadLine());

    //Console.Write("Masukkan angka kedua: ");
    //int angkaKedua = Convert.ToInt32(Console.ReadLine());

    //int[] deretFibonacci = new int[jumlahAngka];
    //deretFibonacci[0] = angkaAwal;
    //deretFibonacci[1] = angkaKedua;

    //for (int i = 2; i < jumlahAngka; i++)
    //{
    //    deretFibonacci[i] = deretFibonacci[i - 1] + deretFibonacci[i - 2];
    //}

    //Console.WriteLine("\nDeret Fibonacci:");
    //for (int i = 0; i < jumlahAngka; i++)
    //{
    //    Console.Write(deretFibonacci[i] + " ");
    //}

    Console.Write("Masukkan jumlah angka dalam deret Fibonacci: ");
    int jumlahAngka;
    while (!int.TryParse(Console.ReadLine(), out jumlahAngka))
    {
        Console.WriteLine("Input tidak valid. Mohon masukkan angka.");
        Console.Write("Masukkan jumlah angka dalam deret Fibonacci: ");
    }

    Console.Write("Masukkan angka awal: ");
    int angkaAwal;
    while (!int.TryParse(Console.ReadLine(), out angkaAwal))
    {
        Console.WriteLine("Input tidak valid. Mohon masukkan angka.");
        Console.Write("Masukkan angka awal: ");
    }

    Console.Write("Masukkan angka kedua: ");
    int angkaKedua;
    while (!int.TryParse(Console.ReadLine(), out angkaKedua))
    {
        Console.WriteLine("Input tidak valid. Mohon masukkan angka.");
        Console.Write("Masukkan angka kedua: ");
    }

    int[] deretFibonacci = new int[jumlahAngka];
    deretFibonacci[0] = angkaAwal;
    deretFibonacci[1] = angkaKedua;

    for (int i = 2; i < jumlahAngka; i++)
    {
        deretFibonacci[i] = deretFibonacci[i - 1] + deretFibonacci[i - 2];
    }

    Console.WriteLine("\nDeret Fibonacci:");
    for (int i = 0; i < jumlahAngka; i++)
    {
        Console.Write(deretFibonacci[i] + " ");
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


//static void cobaprinthurufR()
//    {
//    Console.Write("Masukkan ukuran huruf R: ");
//    int ukuran = Convert.ToInt32(Console.ReadLine());

//    // Matriks representasi huruf R
//    string[,] hurufR = new string[ukuran, ukuran];

//    // Mengisi matriks dengan karakter '*'
//    for (int i = 0; i < ukuran; i++)
//    {
//        for (int j = 0; j < ukuran; j++)
//        {
//            if (j == 0 || i == 0 || i == ukuran / 2 || (i == j && i >= ukuran / 2))
//            {
//                hurufR[i, j] = "*";
//            }
//            else
//            {
//                hurufR[i, j] = " ";
//            }
//        }
//    }

//    // Mencetak huruf R
//    for (int i = 0; i < ukuran; i++)
//    {
//        for (int j = 0; j < ukuran; j++)
//        {
//            Console.Write(hurufR[i, j]);
//        }
//        Console.WriteLine();
//    }
//}

static void gambarrumah()
{
    int tinggi = 7; // Tinggi dari gambar rumah (jumlah baris)

    // Mencetak atap
    for (int i = 1; i <= tinggi / 2 + 1; i++)
    {
        for (int j = 1; j <= tinggi / 2 + 1 - i; j++)
        {
            Console.Write(" ");
        }
        for (int k = 1; k <= 2 * i - 1; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    // Mencetak dinding
    for (int i = 1; i <= tinggi / 2; i++)
    {
        Console.Write("");
        Console.Write("*");
        for (int j = 1; j <= tinggi - 2; j++)
        {
            Console.Write(" ");
        }
        Console.Write("*");
        Console.WriteLine();
    }

    // Mencetak alas
    for (int i = 1; i <= tinggi; i++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}


static void kalkulator()
{
    bool selesai = false;

    while (!selesai)
    {
        Console.WriteLine("Masukkan operasi matematika (+, -, *, /) atau 'selesai' untuk keluar:");
        string operasi = Console.ReadLine();

        if (operasi.ToLower() == "selesai")
        {
            selesai = true;
            continue;
        }

        Console.WriteLine("Masukkan angka pertama:");
        double angka1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Masukkan angka kedua:");
        double angka2 = Convert.ToDouble(Console.ReadLine());

        double hasil = 0;

        switch (operasi)
        {
            case "+":
                hasil = angka1 + angka2;
                break;
            case "-":
                hasil = angka1 - angka2;
                break;
            case "*":
                hasil = angka1 * angka2;
                break;
            case "/":
                if (angka2 != 0)
                {
                    hasil = angka1 / angka2;
                }
                else
                {
                    Console.WriteLine("Pembagian dengan nol tidak diizinkan.");
                    continue;
                }
                break;
            default:
                Console.WriteLine("Operasi tidak valid.");
                continue;
        }

        Console.WriteLine("Hasil: " + hasil);
        Console.WriteLine();
    }
}

static void number8()
{
    Console.WriteLine(" Nomer 8");
    Console.WriteLine(" ====== ");
    
    Console.Write("Masukan angka: ");
    int angka = int.Parse(Console.ReadLine());


    var x = angka;
    for (int i = 0; i < angka; i++)
    {
        for (int j = 0; j < angka; j++)
        {
            if (i == 0)
            {
                Console.Write($"{j + 1}\t");

            }
            else if (i == angka - 1)
            {
                //x -= 1;
                Console.Write($"{x}\t");
                x -= 1;
            }
            else if (j == 0 || j == angka - 1)
            {
                Console.Write($"*\t");
            }
            else
            {
                Console.Write($"\t");
            }
        }
        Console.WriteLine();

    }
}
