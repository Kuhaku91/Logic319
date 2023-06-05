//nilai();
//soal5();
//number3();

Console.ReadKey();
//static void nilai()
//{
//    Console.WriteLine("Program Penentuan Nilai");
//    Console.WriteLine("=======================");
//    Console.WriteLine("Masukan Nilai Siswa : ");
//    int nilai = Convert.ToInt32(Console.ReadLine());

//    string grade = hasil(nilai);


//    if (nilai > 100 || nilai < 0)
//    {
//        Console.WriteLine("Nilai Tidak valid harap masukan lagi !! ");

//    }
//    else
//    {
//        Console.WriteLine("Nilai anda adalah " + grade );
//    }
//    Console.ReadLine();
//}

//static string nilai()
//{
//    if (nilai >= 90)
//        return "A";
//    else if (nilai >= 70)
//        return "B";
//    else if (nilai >= 50)
//        return "C";
//    else if (nilai < 50)
//        return "E";
//}


static void Nomer2()
{
    Console.Write("Masukkan jumlah pulsa yang dibeli: ");
    double jumlahPulsa = Convert.ToDouble(Console.ReadLine());

    double poin = HitungPoinPulsa(jumlahPulsa);
    Console.WriteLine("Poin yang Anda dapatkan: " + poin);
}

static double HitungPoinPulsa(double jumlahPulsa)
{
    double poin = 0;

    if (jumlahPulsa >= 10000)
    {
        poin = 80;
    }
    else if (jumlahPulsa >= 25000)
    {
        poin = 200;
    }
    else if (jumlahPulsa >= 50000)
    {
        poin = 400;
    }
    else if (jumlahPulsa >= 100000)
    {
        poin = 800;
    }
    else if (jumlahPulsa < 10000)
    {
        Console.WriteLine("Pembelian pulsa harus minimal 10.000 untuk mendapatkan poin.");
    }
    else
    {
        Console.WriteLine("Pulsa tidak memenuhi kriteria untuk mendapatkan poin.");
    }

    return poin;
}

//static void Numer3()
//{

//class Program
//{
//static void number3()
{
    Console.Write("Masukkan total pembelanjaan: ");
    double totalPembelanjaan = Convert.ToDouble(Console.ReadLine());

    Console.Write("Masukkan jarak pengiriman dalam km: ");
    int jarakPengiriman = Convert.ToInt32(Console.ReadLine());

    double diskon = HitungDiskon(totalPembelanjaan);
    double ongkosKirim = HitungOngkosKirim(jarakPengiriman);

    double totalPembayaran = totalPembelanjaan - diskon + ongkosKirim;

    Console.WriteLine("");
    Console.WriteLine("Total pembayaran: " + totalPembayaran);
}

static double HitungDiskon(double totalPembelanjaan)
{
    double diskon = 0;

    if (totalPembelanjaan >= 30000)
    {
        diskon = Math.Min(totalPembelanjaan * 0.4, 30000);
    }

    return diskon;
}

static double HitungOngkosKirim(int jarakPengiriman)
{
    int jarakMin = 5;
    int biayaOngkosKirim = 5000;
    int tambahanPerKm = 1000;

    int jarakLebih = Math.Max(jarakPengiriman - jarakMin, 0);
    double ongkosKirim = biayaOngkosKirim + (tambahanPerKm * jarakLebih);

    return ongkosKirim;
}




static void soal1()
{
    Console.WriteLine("Program Grade Nilai");
    Console.Write("Inputkan Nilai = ");
    int nilai = int.Parse(Console.ReadLine());

    if (nilai >= 90 && nilai <= 100)
    {
        Console.WriteLine("Grade Nilai Anda \t : A");
    }
    else if (nilai >= 70 && nilai <= 89)
    {
        Console.WriteLine("Grade Nilai Anda \t : B");
    }
    else if (nilai >= 50 && nilai <= 69)
    {
        Console.WriteLine("Grade Nilai Anda \t : C");
    }
    else if (nilai < 50 && nilai >= 0)
    {
        Console.WriteLine("Grade Nilai Anda \t : E");
    }
    else { Console.WriteLine("Nilai Tidak Terdefenisi"); }
}

static void soal5()
{
    Console.WriteLine("Program Generasi");
    Console.Write("Input Nama Anda \t = ");
    string nama = Console.ReadLine();
    Console.Write("Inputkan Tahun Kelahiran Anda \t = ");
    int thn = int.Parse(Console.ReadLine());

    if (thn >= 1944 && thn <= 1964)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong Generasi Boomer ");
    }
    else if (thn >= 1965 && thn <= 1979)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong Generasi X ");
    }
    else if (thn >= 1980 && thn <= 1994)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong Generasi Y ");
    }
    else if (thn >= 1995 && thn <= 2015)
    {
        Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tergolong Generasi Z ");
    }
    else
    {
        Console.WriteLine("Generasi anda tidak terdefinisi");
    }
}

static void soal6()
{
    Console.WriteLine("Program GAJI PAJAK");
    Console.Write("Nama \t : ");
    string nama = Console.ReadLine();
    Console.Write("Tunjangan \t : ");
    int tunj = int.Parse(Console.ReadLine());
    Console.Write("Gaji pokpok \t : ");
    int gap = int.Parse(Console.ReadLine());
    Console.Write("Banyak Bulan \t : ");
    int moon = int.Parse(Console.ReadLine());

    int galan, totga, gaji;
    double pajak, bpjs, gbln, gtot;
    gaji = tunj + gap;

    if (gaji <= 5000000)
    {
        pajak = 0.05 * gaji;
        bpjs = 0.03 * gaji;
        gbln = (gap + tunj) - (pajak + bpjs);
        gtot = gbln * moon;

        Console.WriteLine($"Karyawan atas nama {nama} slip gaji sebagai berikut : ");
        Console.WriteLine($"Pajak \t Rp. {pajak} ");
        Console.WriteLine($"Bpjs \t Rp. {bpjs} ");
        Console.WriteLine($"Gaji/Bulan \t Rp. {gbln} ");
        Console.WriteLine($"Total Gaji \t Rp. {gtot} ");
    }
    else if (gaji > 5000000 && gaji <= 10000000)
    {
        pajak = 0.10 * gaji;
        bpjs = 0.03 * gaji;
        gbln = (gap + tunj) - (pajak + bpjs);
        gtot = gbln * moon;

        Console.WriteLine($"Karyawan atas nama {nama} slip gaji sebagai berikut : ");
        Console.WriteLine($"Pajak \t Rp. {pajak} ");
        Console.WriteLine($"Bpjs \t Rp. {bpjs} ");
        Console.WriteLine($"Gaji/Bulan \t Rp. {gbln} ");
        Console.WriteLine($"Total Gaji \t Rp. {gtot} ");
    }
    else if (gaji > 10000000)
    {
        pajak = 0.15 * gaji;
        bpjs = 0.03 * gaji;
        gbln = (gap + tunj) - (pajak + bpjs);
        gtot = gbln * moon;

        Console.WriteLine($"Karyawan atas nama {nama} slip gaji sebagai berikut : ");
        Console.WriteLine($"Pajak \t Rp. {pajak} ");
        Console.WriteLine($"Bpjs \t Rp. {bpjs} ");
        Console.WriteLine($"Gaji/Bulan \t Rp. {gbln} ");
        Console.WriteLine($"Total Gaji \t Rp. {gtot} ");
    }
    else
    {
        Console.WriteLine("Invalid!!");
    }
}

static void soal8()
{
    Console.WriteLine("Program KKM");
    Console.Write("Masukkan Nilai MTK \t : ");
    int mtk = int.Parse(Console.ReadLine());

    Console.Write("Masukkan Nilai Fisika \t : ");
    int fis = int.Parse(Console.ReadLine());

    Console.Write("Masukkan Nilai Kimia \t : ");
    int kim = int.Parse(Console.ReadLine());
    Console.WriteLine();

    int rata = (mtk + fis + kim) / 3;
    Console.WriteLine($"Nilai Rata-Rata \t : {rata}");

    if (rata >= 50)
    {
        Console.WriteLine("Selamaat");
        Console.WriteLine("Kamu Berhasil");
        Console.WriteLine("Kamu Hebat");
    }
    else if (rata < 50)
    {
        Console.WriteLine("Maaf");
        Console.WriteLine("Kamu Gagal :(");
    }
    else
    {

    }

}

static void soal2()
{
    Console.WriteLine("Program Grade Nilai");
    Console.Write("Inputkan Nominal Pulsa Anda = ");
    int pulsa = int.Parse(Console.ReadLine());

    if (pulsa >= 10000 && pulsa < 25000)
    {
        Console.WriteLine($"Pulsa \t : {pulsa}");
        Console.WriteLine("Point \t : 80");
    }
    else if (pulsa >= 25000 && pulsa < 50000)
    {
        Console.WriteLine($"Pulsa \t : {pulsa}");
        Console.WriteLine("Point \t : 200");
    }
    else if (pulsa >= 50000 && pulsa < 100000)
    {
        Console.WriteLine($"Pulsa \t : {pulsa}");
        Console.WriteLine("Point \t : 400");
    }
    else if (pulsa > 100000)
    {
        Console.WriteLine($"Pulsa \t : {pulsa}");
        Console.WriteLine("Point \t : 800");
    }
    else { Console.WriteLine("Beli Pulsa Lagi dan Dapatkan Poinnya"); }
}

static void number3()

{
    double diskon = 0, belanja, ongkir, total = 0;

    Console.WriteLine("Program Diskon OVO Grab");
    Console.Write("Inputkan Total Belanja \t = ");
    int shop = int.Parse(Console.ReadLine());
    Console.Write("Inputkan Jarak \t = ");
    int jarak = int.Parse(Console.ReadLine());
    Console.Write("Kode Promo \t = ");
    string promo = Console.ReadLine();

    //ongkir = jarak * 1000;
    ongkir = jarak <= 5 ? 5000 : jarak * 1000;
    Console.WriteLine();
    if (promo.ToUpper() == "JKTOVO" && shop >= 30000)
    {
        diskon = shop * 0.4;
        if (diskon > 30000)
        {
            diskon = 30000;
        }
    }
    Console.WriteLine($"Belanja \t : {shop} ");
    Console.WriteLine($"Diskon 40% \t : {diskon} ");
    Console.WriteLine($"Ongkir \t \t : {ongkir} ");
    Console.WriteLine($"Total Belanja \t : {shop + ongkir - diskon} ");

    //if (shop >= 30000 && shop <= 75000)
    //{
    //    diskon = shop * 0.4;
    //    belanja = shop - diskon;
    //    Console.WriteLine($"Belanja \t : {shop} ");
    //    Console.WriteLine($"Diskon 40% \t : {diskon} ");
    //    Console.WriteLine($"Ongkir \t \t : {ongkir} ");
    //    total = belanja + ongkir;
    //    Console.WriteLine($"Total Belanja \t : {total} ");
    //}
    //else if (shop > 75000)
    //{
    //    Console.WriteLine($"Belanja \t : {shop} ");
    //    Console.WriteLine($"Diskon 40% \t : 30000 ");
    //    Console.WriteLine($"Ongkir \t \t : {ongkir} ");
    //    total = (shop - 30000) + ongkir;
    //    Console.Write($"Total Belanja \t : {total} ");
    //}
    //else if (shop < 30000 || promo  != "JKTOVO")
    //{
    //    Console.WriteLine($"Belanja \t : {shop} ");
    //    Console.WriteLine($"Diskon 40% \t : No Diskon ");
    //    Console.WriteLine($"Ongkir \t \t : {ongkir} ");
    //    total = shop + ongkir;
    //    Console.WriteLine($"Total Belanja \t : {total} ");
    //}
    //else
    //{
    //    Console.WriteLine("input yang anda masukan salah");
    //}

}
static void soal4()
{
    int total;
    Console.WriteLine("Program Diskon Voucher Sopi");
    Console.WriteLine("Voucher Sopi :");
    Console.WriteLine("1. Min Order 30rb free ongkir 5rb dan potongan harga belanja 5rb");
    Console.WriteLine("2. Min Order 50rb free ongkir 10rb dan potongan harga belanja 10rb");
    Console.WriteLine("3. Min Order 100rb free ongkir 20rb dan potongan harga belanja 10rb \n");

    Console.Write("Inputkan Total Belanja \t = ");
    int shop = int.Parse(Console.ReadLine());
    Console.Write("Inputkan Ongkos Kirim \t = ");
    int ongkir = int.Parse(Console.ReadLine());
    Console.Write("Pilih Voucher \t = ");
    int promo = int.Parse(Console.ReadLine());

    if (shop >= 30000 && promo == 1)
    {
        total = shop + ongkir - 5000 - 5000;
        Console.WriteLine($"Belanja \t : {shop} ");
        Console.WriteLine($"Ongkos Kirim \t : {ongkir} ");
        Console.WriteLine("Diskon Ongkir \t : 5000 ");
        Console.WriteLine("Diskon Belanja \t : 5000 ");
        Console.WriteLine($"Total Belanja \t : {total} ");
    }
    else if (shop >= 50000 && promo == 2)
    {
        total = shop + ongkir - 10000 - 10000;
        Console.WriteLine($"Belanja \t : {shop} ");
        Console.WriteLine($"Ongkos Kirim \t : {ongkir} ");
        Console.WriteLine("Diskon Ongkir \t : 10000 ");
        Console.WriteLine("Diskon Belanja \t : 10000 ");
        Console.WriteLine($"Total Belanja \t : {total} ");
    }
    else if (shop >= 100000 && promo == 3)
    {
        total = shop + ongkir - 20000 - 10000;
        Console.WriteLine($"Belanja \t : {shop} ");
        Console.WriteLine($"Ongkos Kirim \t : {ongkir} ");
        Console.WriteLine("Diskon Ongkir \t : 20000 ");
        Console.WriteLine("Diskon Belanja \t : 10000 ");
        Console.WriteLine($"Total Belanja \t : {total} ");
    }
    else
    {
        Console.WriteLine("Tidak Dapat Menggunakan Voucher");
    }
}



static void soal7()
{
    Console.WriteLine("Menghitung Body Mass Index");
    Console.WriteLine("==========================");

    Console.WriteLine("Program Body Mass Index");
    Console.Write("Masukkan Berat Badan Anda (kg)  : ");
    float berat = float.Parse(Console.ReadLine());

    Console.Write("Masukkan Tinggi Badan Anda (cm)  : ");
    float tinggi = float.Parse(Console.ReadLine());

    float bmi, height;
    height = (tinggi / 100) * (tinggi / 100);

    bmi = berat / height;

    Console.WriteLine($"Nilai BMI anda adalah  : {bmi}");

    if (bmi < 18.5)
    {
        Console.WriteLine("Anda cungkring");
    }
    else if (bmi > 18.5 && bmi < 25)
    {
        Console.WriteLine("Anda berbadan Langsing");
    }
    else if (bmi >= 25)
    {
        Console.WriteLine("Sudah waktunya anda diet");
    }
    else
    {

    }
}


