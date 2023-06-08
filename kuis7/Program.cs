//number1();
//number2();
number3();
//number4();
//number5();
//number6();
//number8();
//number9();
//number10();

Console.ReadKey();

// cara 1 untuk nomer 1
//static void number1()
//{
//    Console.Write("Masukkan jumlah anak: ");
//    int x = Convert.ToInt32(Console.ReadLine());

//    int result = CalculateSeatingArrangements(x);
//    Console.WriteLine("Jumlah cara mereka dapat duduk bersama di bangku tersebut adalah: " + result);
//}

//static int CalculateSeatingArrangements(int x)
//{
//    if (x <= 0)
//        return 0;

//    int factorial = 1;
//    for (int i = 2; i <= x; i++)
//    {
//        factorial *= i;
//    }

//    return factorial;
//}

static void nomer1()
{
    Console.WriteLine(" Masukan nilai anak : ");
    int x = int.Parse(Console.ReadLine());

    string taampung = "";

    int faktorial = 1;
    
    for (int i = x; i >= 1; i++)
    {
        _ = faktorial;
    }
}


// cara ke2 nomer 1

//static void number1()
//{
//    Console.Write("Masukkan jumlah anak: ");
//    int x = Convert.ToInt32(Console.ReadLine());

//    long numWays = CalculateWays(x);
//    Console.WriteLine("Jumlah cara anak-anak dapat duduk bersama: " + numWays);
//}

//static long CalculateWays(int x)
//{
//    long factorial = 1;
//    for (int i = 2; i <= x; i++)
//    {
//        factorial *= i;
//    }
//    return factorial;
//}


// cara ketiga number 1
//static void number1()
//{
//    Console.Write("Masukkan jumlah anak: ");
//    string input = Console.ReadLine();

//    if (int.TryParse(input, out int x))
//    {
//        int result = CalculateSeatingArrangements(x);
//        Console.WriteLine("Jumlah cara mereka dapat duduk bersama di bangku tersebut adalah: " + result);
//    }
//    else
//    {
//        Console.WriteLine("Input yang dimasukkan tidak valid.");
//    }
//}

//static int CalculateSeatingArrangements(int x)
//{
//    if (x <= 0)
//        return 0;

//    int factorial = 1;
//    for (int i = 2; i <= x; i++)
//    {
//        factorial *= i;
//    }

//    return factorial;
//}


// Number 1 cara 4

static void number1()
{
    Console.Write("Masukkan jumlah anak: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int x))
    {
        int result = hitung(x);
        Console.WriteLine("Jumlah cara mereka dapat duduk bersama di bangku tersebut adalah: " + result);
    }
    else
    {
        Console.WriteLine("Input yang dimasukkan tidak valid.");
    }
}

static int hitung(int x)
{
    if (x <= 0)
        return 0;

    int factorial = 1;
    for (int i = 2; i <= x; i++)
    {
        factorial *= i;
    }

    return factorial;
}


// number 2 cara 1
//static void number2()
//{
//    Console.Write("Masukkan sinyal yang diterima: ");
//    string receivedSignal = Console.ReadLine();

//    Console.Write("Masukkan sinyal yang benar: ");
//    string correctSignal = Console.ReadLine();

//    int errorCount = CountErrors(receivedSignal, correctSignal);
//    Console.WriteLine("Total sinyal yang salah: " + errorCount);
//}

//static int CountErrors(string receivedSignal, string correctSignal)
//{
//    if (receivedSignal.Length != correctSignal.Length)
//        throw new ArgumentException("Panjang sinyal yang diterima dan sinyal yang benar harus sama.");

//    int errorCount = 0;
//    for (int i = 0; i < receivedSignal.Length; i++)
//    {
//        if (receivedSignal[i] != correctSignal[i])
//            errorCount++;
//    }

//    return errorCount;
//}

// number 2 cara ke2

static void number2()
{
    Console.Write("Masukkan sinyal yang diterima: ");
    string receivedSignal = Console.ReadLine();

    int errorCount = CountErrors(receivedSignal);
    Console.WriteLine("Total sinyal yang salah: " + errorCount);
}

static int CountErrors(string receivedSignal)
{
    string correctSignal = "SOSSOSSOSSOS";
    int errorCount = 0;

    for (int i = 0; i < receivedSignal.Length; i++)
    {
        if (receivedSignal[i] != correctSignal[i % 12])
            errorCount++;
    }

    return errorCount;
}

// cara ke 3 nomer 2

//static void number2()
//{
//    Console.Write("Masukkan sinyal yang diterima: ");
//    string receivedSignal = Console.ReadLine();

//    int errorCount = CountErrors(receivedSignal);
//    Console.WriteLine("Total sinyal yang salah: " + errorCount);
//}

//static int CountErrors(string receivedSignal)
//{
//    string correctSignal = "SOS";
//    int errorCount = 0;

//    for (int i = 0; i < receivedSignal.Length; i += 3)
//    {
//        if (receivedSignal.Substring(i, 3) != correctSignal)
//            errorCount++;
//    }

//    return errorCount;
//}


// nomer 3 cara 1

//static void number3()
//{
//    DateTime tanggalPeminjaman = new DateTime(2019, 6, 9);
//    DateTime tanggalPengembalian = new DateTime(2019, 7, 10);
//    int dendaPerHari = 500;

//    int denda = CalculateDenda(tanggalPeminjaman, tanggalPengembalian, dendaPerHari);
//    Console.WriteLine("Total denda yang harus dibayar oleh Mono: " + denda);
//}

//static int CalculateDenda(DateTime tanggalPeminjaman, DateTime tanggalPengembalian, int dendaPerHari)
//{
//    TimeSpan selisihWaktu = tanggalPengembalian - tanggalPeminjaman;
//    int selisihHari = selisihWaktu.Days;

//    int denda = 0;
//    if (selisihHari > 3)
//    {
//        int hariTerlambat = selisihHari - 3;
//        denda = hariTerlambat * dendaPerHari;
//    }

//    return denda;
//}


// nomer 3 cara ke 2
static void number3()
{
    Console.Write("Masukkan tanggal peminjaman (dd-mm-yyyy): ");
    string peminjamanStr = Console.ReadLine();
    DateTime tanggalPeminjaman = DateTime.ParseExact(peminjamanStr, "dd-MM-yyyy", null);

    Console.Write("Masukkan tanggal seharusnya dikembalikan (dd-mm-yyyy): ");
    string seharusnyaDikembalikanStr = Console.ReadLine();
    DateTime tanggalSeharusnyaDikembalikan = DateTime.ParseExact(seharusnyaDikembalikanStr, "dd-MM-yyyy", null);

    Console.Write("Masukkan tanggal dikembalikan (dd-mm-yyyy): ");
    string dikembalikanStr = Console.ReadLine();
    DateTime tanggalDikembalikan = DateTime.ParseExact(dikembalikanStr, "dd-MM-yyyy", null);

    int dendaPerHari = 500;

    int denda = CalculateDenda(tanggalPeminjaman, tanggalSeharusnyaDikembalikan, tanggalDikembalikan, dendaPerHari);
    Console.WriteLine("Total denda yang harus dibayar: " + denda);
}

static int CalculateDenda(DateTime tanggalPeminjaman, DateTime tanggalSeharusnyaDikembalikan, DateTime tanggalDikembalikan, int dendaPerHari)
{
    if (tanggalDikembalikan <= tanggalSeharusnyaDikembalikan)
        return 0;

    TimeSpan selisihWaktu = tanggalDikembalikan - tanggalSeharusnyaDikembalikan;
    int selisihHari = selisihWaktu.Days;

    int denda = selisihHari * dendaPerHari;

    return denda;
}


//nomer 4 cara 1
static void number4()
{
    Console.Write("Tanggal mulai (dd/mm/yyyy): ");
    string tanggalMulaiStr = Console.ReadLine();
    DateTime tanggalMulai = DateTime.ParseExact(tanggalMulaiStr, "dd/MM/yyyy", null);

    Console.Write("Hari Libur (dd/mm/yyyy, pisahkan dengan koma jika ada lebih dari satu): ");
    string hariLiburStr = Console.ReadLine();
    string[] hariLiburArray = hariLiburStr.Split(',');

    int durasiKelas = 10;

    DateTime tanggalUjian = CalculateTanggalUjian(tanggalMulai, durasiKelas, hariLiburArray);
    Console.WriteLine("Kelas akan ujian pada: " + tanggalUjian.ToString("dd/MM/yyyy"));
}

static DateTime CalculateTanggalUjian(DateTime tanggalMulai, int durasiKelas, string[] hariLiburArray)
{
    DateTime tanggalUjian = tanggalMulai.AddDays(durasiKelas);

    foreach (string hariLibur in hariLiburArray)
    {
        DateTime tanggalLibur = DateTime.ParseExact(hariLibur.Trim(), "dd/MM/yyyy", null);

        if (tanggalLibur > tanggalMulai && tanggalLibur <= tanggalUjian)
        {
            tanggalUjian = tanggalUjian.AddDays(1);
        }
    }

    while (tanggalUjian.DayOfWeek == DayOfWeek.Saturday || tanggalUjian.DayOfWeek == DayOfWeek.Sunday)
    {
        tanggalUjian = tanggalUjian.AddDays(1);
    }

    return tanggalUjian;
}

// nomer 4 cara ke 2

//static void number4()
//{
//    Console.Write("Tanggal mulai (dd/MM/yyyy): ");
//    string tanggalMulaiStr = Console.ReadLine();
//    DateTime tanggalMulai = DateTime.ParseExact(tanggalMulaiStr, "dd/MM/yyyy", null);

//    Console.Write("Hari Libur (dd/MM/yyyy, pisahkan dengan koma jika ada lebih dari satu): ");
//    string hariLiburStr = Console.ReadLine();
//    string[] hariLiburArray = hariLiburStr.Split(',');

//    Console.Write("Lama kelas berlangsung (dalam jumlah hari): ");
//    int lamaKelas = int.Parse(Console.ReadLine());

//    DateTime tanggalUjian = HitungTanggalUjian(tanggalMulai, lamaKelas, hariLiburArray);
//    Console.WriteLine("Tanggal kelas ujian: " + tanggalUjian.ToString("dd/MM/yyyy"));
//}

//static DateTime HitungTanggalUjian(DateTime tanggalMulai, int lamaKelas, string[] hariLiburArray)
//{
//    DateTime tanggalUjian = tanggalMulai;

//    int hariDilaksanakan = 0;
//    int totalHari = 0;

//    while (hariDilaksanakan < lamaKelas)
//    {
//        tanggalUjian = tanggalUjian.AddDays(1);

//        if (tanggalUjian.DayOfWeek == DayOfWeek.Saturday || tanggalUjian.DayOfWeek == DayOfWeek.Sunday)
//            continue;

//        totalHari++;

//        bool adaLibur = false;
//        foreach (string hariLibur in hariLiburArray)
//        {
//            DateTime tanggalLibur = DateTime.ParseExact(hariLibur.Trim(), "dd/MM/yyyy", null);

//            if (tanggalUjian.Date == tanggalLibur.Date)
//            {
//                adaLibur = true;
//                break;
//            }
//        }

//        if (!adaLibur)
//            hariDilaksanakan++;
//    }

//    return tanggalUjian;
//}


// number 5

//static void number5()
//{
//    Console.Write("Masukkan sebuah string: ");
//    string input = Console.ReadLine();

//    int jumlahVokal, jumlahKonsonan;
//    HitungHuruf(input, out jumlahVokal, out jumlahKonsonan);

//    Console.WriteLine("Jumlah huruf vokal: " + jumlahVokal);
//    Console.WriteLine("Jumlah huruf konsonan: " + jumlahKonsonan);
//}

//static void HitungHuruf(string input, out int jumlahVokal, out int jumlahKonsonan)
//{
//    jumlahVokal = 0;
//    jumlahKonsonan = 0;

//    foreach (char huruf in input.ToLower())
//    {
//        if (Char.IsLetter(huruf))
//        {
//            if (huruf == 'a' || huruf == 'e' || huruf == 'i' || huruf == 'o' || huruf == 'u')
//                jumlahVokal++;
//            else
//                jumlahKonsonan++;
//        }
//    }
//}

// nomer 5 cara ke 2
//static void number5()
//{
//    Console.Write("Masukkan sebuah kalimat: ");
//    string kalimat = Console.ReadLine();

//    int jumlahVokal, jumlahKonsonan;
//    HitungJumlahHuruf(kalimat, out jumlahVokal, out jumlahKonsonan);

//    Console.WriteLine("Jumlah huruf vokal: " + jumlahVokal);
//    Console.WriteLine("Jumlah huruf konsonan: " + jumlahKonsonan);
//}

//static void HitungJumlahHuruf(string kalimat, out int jumlahVokal, out int jumlahKonsonan)
//{
//    jumlahVokal = 0;
//    jumlahKonsonan = 0;

//    foreach (char karakter in kalimat.ToLower())
//    {
//        if (char.IsLetter(karakter))
//        {
//            if (IsVokal(karakter))
//                jumlahVokal++;
//            else
//                jumlahKonsonan++;
//        }
//    }
//}

//static bool IsVokal(char karakter)
//{
//    char[] vokal = { 'a', 'e', 'i', 'o', 'u' };
//    return Array.Exists(vokal, v => v == karakter);
//}

// nomer 5 cara ke3

static void number5()
{
    Console.Write("Masukkan sebuah kalimat: ");
    string kalimat = Console.ReadLine();

    int jumlahVokal, jumlahKonsonan;
    HitungJumlahHuruf(kalimat, out jumlahVokal, out jumlahKonsonan);

    Console.WriteLine("Jumlah huruf vokal: " + jumlahVokal);
    Console.WriteLine("Jumlah huruf konsonan: " + jumlahKonsonan);
}

static void HitungJumlahHuruf(string kalimat, out int jumlahVokal, out int jumlahKonsonan)
{
    jumlahVokal = 0;
    jumlahKonsonan = 0;

    foreach (char karakter in kalimat.ToLower())
    {
        if (char.IsLetter(karakter))
        {
            if (IsVokal(karakter))
                jumlahVokal++;
            else
                jumlahKonsonan++;
        }
        else
        {
            Console.WriteLine("Input tidak valid. Harap masukkan hanya huruf.");
            return;
        }
    }
}

static bool IsVokal(char karakter)
{
    char[] vokal = { 'a', 'e', 'i', 'o', 'u' };
    return Array.Exists(vokal, v => v == karakter);
}


// number 6

static void number6()
{
    Console.Write("Masukkan sebuah kata: ");
    string kata = Console.ReadLine();

    if (!IsOnlyLetters(kata))
    {
        Console.WriteLine("Input tidak valid. Harap masukkan hanya huruf.");
        return;
    }

    for (int i = 0; i < kata.Length; i++)
    {
        Console.WriteLine("***" + kata[i] + "***");
    }
}

static bool IsOnlyLetters(string input)
{
    foreach (char karakter in input)
    {
        if (!char.IsLetter(karakter))
            return false;
    }
    return true;
}

//number 8 cara 1

//static void number8()
//{
//    int jumlahSegitiga;

//    Console.Write("Masukkan jumlah segitiga yang ingin dicetak: ");
//    while (!int.TryParse(Console.ReadLine(), out jumlahSegitiga))
//    {
//        Console.WriteLine("Input tidak valid. Harap masukkan angka.");
//        Console.Write("Masukkan jumlah segitiga yang ingin dicetak: ");
//    }

//    for (int i = 0; i < jumlahSegitiga; i++)
//    {
//        Console.Write("Masukkan tinggi segitiga ke-" + (i + 1) + ": ");
//        int tinggi;

//        while (!int.TryParse(Console.ReadLine(), out tinggi) || tinggi < 1)
//        {
//            Console.WriteLine("Input tidak valid. Harap masukkan angka positif.");
//            Console.Write("Masukkan tinggi segitiga ke-" + (i + 1) + ": ");
//        }

//        Console.WriteLine("Segitiga ke-" + (i + 1) + ":");
//        CetakSegitiga(tinggi);
//        Console.WriteLine();
//    }
//}

//static void CetakSegitiga(int tinggi)
//{
//    for (int i = 1; i <= tinggi; i++)
//    {
//        for (int j = 1; j <= i; j++)
//        {
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//}

//  nomer 8 cara ke 2
//static void number8()
//{
//    int jumlahSegitiga;

//    Console.Write("Masukkan jumlah segitiga yang ingin dicetak: ");
//    while (!int.TryParse(Console.ReadLine(), out jumlahSegitiga))
//    {
//        Console.WriteLine("Input tidak valid. Harap masukkan angka.");
//        Console.Write("Masukkan jumlah segitiga yang ingin dicetak: ");
//    }

//    for (int i = 0; i < jumlahSegitiga; i++)
//    {
//        Console.WriteLine("Segitiga ke-" + (i + 1) + ":");

//        Console.Write("Masukkan jenis segitiga (1: Segitiga Siku-siku, 2: Segitiga Sama Sisi): ");
//        int jenisSegitiga;

//        while (!int.TryParse(Console.ReadLine(), out jenisSegitiga) || (jenisSegitiga != 1 && jenisSegitiga != 2))
//        {
//            Console.WriteLine("Input tidak valid. Harap masukkan angka 1 atau 2.");
//            Console.Write("Masukkan jenis segitiga (1: Segitiga Siku-siku, 2: Segitiga Sama Sisi): ");
//        }

//        Console.Write("Masukkan tinggi segitiga: ");
//        int tinggi;

//        while (!int.TryParse(Console.ReadLine(), out tinggi) || tinggi < 1)
//        {
//            Console.WriteLine("Input tidak valid. Harap masukkan angka positif.");
//            Console.Write("Masukkan tinggi segitiga: ");
//        }

//        switch (jenisSegitiga)
//        {
//            case 1:
//                CetakSegitigaSikuSiku(tinggi);
//                break;
//            case 2:
//                CetakSegitigaSamaSisi(tinggi);
//                break;
//        }

//        Console.WriteLine();
//    }
//}

//static void CetakSegitigaSikuSiku(int tinggi)
//{
//    for (int i = 1; i <= tinggi; i++)
//    {
//        for (int j = 1; j <= i; j++)
//        {
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//}

//static void CetakSegitigaSamaSisi(int tinggi)
//{
//    for (int i = 1; i <= tinggi; i++)
//    {
//        for (int j = 1; j <= tinggi - i; j++)
//        {
//            Console.Write(" ");
//        }

//        for (int k = 1; k <= (2 * i) - 1; k++)
//        {
//            Console.Write("*");
//        }

//        Console.WriteLine();
//    }
//}

// nomer 8 cara ke3

//static void number8()
//{
//    int jumlahSegitiga;

//    Console.Write("Masukkan jumlah segitiga yang ingin dicetak: ");
//    while (!int.TryParse(Console.ReadLine(), out jumlahSegitiga))
//    {
//        Console.WriteLine("Input tidak valid. Harap masukkan angka.");
//        Console.Write("Masukkan jumlah segitiga yang ingin dicetak: ");
//    }

//    for (int i = 0; i < jumlahSegitiga; i++)
//    {
//        Console.WriteLine("Segitiga ke-" + (i + 1) + ":");

//        Console.Write("Masukkan jenis segitiga (1: Segitiga Siku-siku, 2: Segitiga Siku-siku Terbalik): ");
//        int jenisSegitiga;

//        while (!int.TryParse(Console.ReadLine(), out jenisSegitiga) || (jenisSegitiga != 1 && jenisSegitiga != 2))
//        {
//            Console.WriteLine("Input tidak valid. Harap masukkan angka 1 atau 2.");
//            Console.Write("Masukkan jenis segitiga (1: Segitiga Siku-siku, 2: Segitiga Siku-siku Terbalik): ");
//        }

//        Console.Write("Masukkan tinggi segitiga: ");
//        int tinggi;

//        while (!int.TryParse(Console.ReadLine(), out tinggi) || tinggi < 1)
//        {
//            Console.WriteLine("Input tidak valid. Harap masukkan angka positif.");
//            Console.Write("Masukkan tinggi segitiga: ");
//        }

//        switch (jenisSegitiga)
//        {
//            case 1:
//                CetakSegitigaSikuSiku(tinggi);
//                break;
//            case 2:
//                CetakSegitigaSikuSikuTerbalik(tinggi);
//                break;
//        }

//        Console.WriteLine();
//    }
//}

//static void CetakSegitigaSikuSiku(int tinggi)
//{
//    for (int i = tinggi; i >= 1; i--)
//    {
//        for (int j = 1; j <= i; j++)
//        {
//            Console.Write("*");
//        }
//        Console.WriteLine();
//    }
//}

//static void CetakSegitigaSikuSikuTerbalik(int tinggi)
//{
//    for (int i = 1; i <= tinggi; i++)
//    {
//        for (int j = 1; j <= i - 1; j++)
//        {
//            Console.Write(" ");
//        }

//        for (int k = tinggi; k >= i; k--)
//        {
//            Console.Write("*");
//        }

//        Console.WriteLine();
//    }
//}

// cara nomer 8 ke 4
static void number8()
{
    int jumlahSegitiga;

    Console.Write("Masukkan jumlah segitiga yang ingin dicetak: ");
    while (!int.TryParse(Console.ReadLine(), out jumlahSegitiga))
    {
        Console.WriteLine("Input tidak valid. Harap masukkan angka.");
        Console.Write("Masukkan jumlah segitiga yang ingin dicetak: ");
    }

    for (int i = 0; i < jumlahSegitiga; i++)
    {
        Console.WriteLine("Segitiga ke-" + (i + 1) + ":");

        Console.Write("Masukkan jenis segitiga (1: Segitiga Siku-siku, 2: Segitiga Siku-siku Terbalik): ");
        int jenisSegitiga;

        while (!int.TryParse(Console.ReadLine(), out jenisSegitiga) || (jenisSegitiga != 1 && jenisSegitiga != 2))
        {
            Console.WriteLine("Input tidak valid. Harap masukkan angka 1 atau 2.");
            Console.Write("Masukkan jenis segitiga (1: Segitiga Siku-siku, 2: Segitiga Siku-siku Terbalik): ");
        }

        Console.Write("Masukkan tinggi segitiga: ");
        int tinggi;

        while (!int.TryParse(Console.ReadLine(), out tinggi) || tinggi < 1)
        {
            Console.WriteLine("Input tidak valid. Harap masukkan angka positif.");
            Console.Write("Masukkan tinggi segitiga: ");
        }

        switch (jenisSegitiga)
        {
            case 1:
                CetakSegitigaSikuSiku(tinggi);
                break;
            case 2:
                CetakSegitigaSikuSikuTerbalik(tinggi);
                break;
        }

        Console.WriteLine();
    }
}

static void CetakSegitigaSikuSiku(int tinggi)
{
    for (int i = 1; i <= tinggi; i++)
    {
        for (int j = 1; j <= tinggi - i; j++)
        {
            Console.Write(" ");
        }

        for (int k = 1; k <= i; k++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }
}

static void CetakSegitigaSikuSikuTerbalik(int tinggi)
{
    for (int i = tinggi; i >= 1; i--)
    {
        for (int j = 1; j <= tinggi - i; j++)
        {
            Console.Write(" ");
        }

        for (int k = 1; k <= i; k++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }
}


// nomer 9

static void number9()
{
    Console.Write("Masukkan ukuran matriks (N x N): ");
    int N;
    while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
    {
        Console.WriteLine("Input tidak valid. Harap masukkan angka positif.");
        Console.Write("Masukkan ukuran matriks (N x N): ");
    }

    int[,] matriks = new int[N, N];

    Console.WriteLine("Masukkan elemen-elemen matriks:");
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Console.Write("Masukkan elemen [" + i + "," + j + "]: ");
            while (!int.TryParse(Console.ReadLine(), out matriks[i, j]))
            {
                Console.WriteLine("Input tidak valid. Harap masukkan angka.");
                Console.Write("Masukkan elemen [" + i + "," + j + "]: ");
            }
        }
    }

    int selisihDiagonal = HitungSelisihDiagonal(matriks);

    Console.WriteLine("Matriks:");
    CetakMatriks(matriks);

    Console.WriteLine("Selisih diagonal matriks: " + selisihDiagonal);
}

static int HitungSelisihDiagonal(int[,] matriks)
{
    int N = matriks.GetLength(0);
    int diagonalUtama = 0;
    int diagonalSekunder = 0;

    for (int i = 0; i < N; i++)
    {
        diagonalUtama += matriks[i, i];
        diagonalSekunder += matriks[i, N - 1 - i];
    }

    return Math.Abs(diagonalUtama - diagonalSekunder);
}

static void CetakMatriks(int[,] matriks)
{
    int N = matriks.GetLength(0);

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Console.Write(matriks[i, j] + " ");
        }
        Console.WriteLine();
    }
}


// number10
//static void number10()
//{
//    Console.WriteLine("Masukkan tinggi lilin (pisahkan dengan spasi):");
//    string input = Console.ReadLine();

//    int[] candles = input.Split(' ').Select(int.Parse).ToArray();

//    int highestCandle = candles.Max();
//    int count = candles.Count(candle => candle == highestCandle);

//    Console.WriteLine("Jumlah lilin yang berhasil ditiup: " + count);
//}

// nomer 10 cara ke 2

static void number10()
{
    Console.WriteLine("Masukkan tinggi lilin, pisahkan dengan spasi: ");
    string input = Console.ReadLine();

    int result = CountBlownCandles(input);
    Console.WriteLine("Jumlah lilin yang berhasil ditiup: " + result);
}

static int CountBlownCandles(string input)
{
    string[] candles = input.Split(' ');
    int maxHeight = 0;
    int count = 0;

    foreach (string candle in candles)
    {
        int height = int.Parse(candle);

        if (height > maxHeight)
        {
            maxHeight = height;
            count = 1;
        }
        else if (height == maxHeight)
        {
            count++;
        }
    }

    return count;
}


// nomer 7
