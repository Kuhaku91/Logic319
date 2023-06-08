
////number1();
////number2();
////number3();
//number4();
////number5();
////number6();

//Console.ReadKey();

//static void number1()
//{
//    //Console.Write("Masukkan deret angka (pisahkan dengan spasi): ");
//    //string input = Console.ReadLine();

//    //string[] angkaString = input.Split(' ');
//    //int[] angka = new int[angkaString.Length];

//    //for (int i = 0; i < angkaString.Length; i++)
//    //{
//    //    angka[i] = Convert.ToInt32(angkaString[i]);
//    //}

//    //Console.Write("Masukkan jumlah angka yang ingin dihitung: ");
//    //int jumlahAngka = Convert.ToInt32(Console.ReadLine());

//    //for (int i = angka.Length; i < jumlahAngka; i++)
//    //{
//    //    angka[i] = angka[i - 1] - angka[i - 2];
//    //}

//    //Console.WriteLine("Deret angka:");
//    //for (int i = 0; i < jumlahAngka; i++)
//    //{
//    //    Console.Write(angka[i] + " ");
//    //}

//    //Console.ReadLine();

//    Console.Write("Masukkan jumlah angka yang ingin ditampilkan: ");
//    int jumlahAngka = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Deret angka:");
//    for (int i = 1; i <= jumlahAngka; i++)
//    {
//        int angka = i * -5;

//        if (i % 2 == 0)
//        {
//            angka *= -1;
//        }

//        Console.Write(angka + " ");
//    }

//    Console.ReadLine();
//}



//static void number2()
//{
//    Console.Write("Masukkan waktu dalam format hh:mm:ss AM/PM: ");
//    string waktuInput = Console.ReadLine();

//    DateTime waktu = DateTime.ParseExact(waktuInput, "hh:mm:ss tt", null);
//    string waktu24Jam = waktu.ToString("HH:mm:ss");

//    Console.WriteLine("Waktu dalam format 24 jam: " + waktu24Jam);
     
//    Console.ReadLine();
//}

//static void number3()
//{
//    Console.WriteLine("Pilih kode baju (1-3):");
//    int kodeBaju = Convert.ToInt32(Console.ReadLine());

//    Console.WriteLine("Pilih kode ukuran (S/M):");
//    string kodeUkuran = Console.ReadLine();

//    string merkBaju = "";
//    int hargaBaju = 0;

//    if (kodeBaju == 1)
//    {
//        merkBaju = "IMP";
//        if (kodeUkuran == "S")
//        {
//            hargaBaju = 200000;
//        }
//        else if (kodeUkuran == "M")
//        {
//            hargaBaju = 220000;
//        }
//        else
//        {
//            hargaBaju = 250000;
//        }
//    }
//    else if (kodeBaju == 2)
//    {
//        merkBaju = "Prada";
//        if (kodeUkuran == "S")
//        {
//            hargaBaju = 150000;
//        }
//        else if (kodeUkuran == "M")
//        {
//            hargaBaju = 160000;
//        }
//        else
//        {
//            hargaBaju = 170000;
//        }
//    }
//    else if (kodeBaju == 3)
//    {
//        merkBaju = "Gucci";
//        if (kodeUkuran == "S" || kodeUkuran == "M")
//        {
//            hargaBaju = 200000;
//        }
//        else
//        {
//            hargaBaju = 200000;
//        }
//    }

//    Console.WriteLine("Merk Baju: " + merkBaju);
//    Console.WriteLine("Harga Baju: " + hargaBaju);

//    Console.ReadLine();
//}


////static void number4()
////{
////    Console.Write("Masukkan jumlah uang Andi: ");
////    int uangAndi = Convert.ToInt32(Console.ReadLine());

////    Console.Write("Masukkan harga baju (pisahkan dengan koma): ");
////    string inputHargaBaju = Console.ReadLine();
////    int[] hargaBaju = Array.ConvertAll(inputHargaBaju.Split(','), int.Parse);
////    Console.Write("Masukkan harga celana (pisahkan dengan koma): ");
////    string inputHargaCelana = Console.ReadLine();
////    int[] hargaCelana = Array.ConvertAll(inputHargaCelana.Split(','), int.Parse);

////    int totalHargaTerbaik = CariTotalHargaTerbaik(uangAndi, hargaBaju, hargaCelana);

////    Console.WriteLine("Total harga terbaik: " + totalHargaTerbaik);
////}

////static int CariTotalHargaTerbaik(int uang, int[] hargaBaju, int[] hargaCelana)
////{
////    int totalHargaTerbaik = 0;

////    foreach (int baju in hargaBaju)
////    {
////        foreach (int celana in hargaCelana)
////        {
////            int totalHarga = baju + celana;

////            if (totalHarga <= uang && totalHarga >= totalHargaTerbaik)
////            {
////                totalHargaTerbaik = totalHarga;
////            }
////        }
////    }

////    return totalHargaTerbaik;
////}

//// cara nomer 4 yang kedua

//static void number4()
//{
//    int uangAndi;
//    int[] hargaBaju;
//    int[] hargaCelana;

//    // Meminta input uang Andi
//    while (true)
//    {
//        Console.Write("Masukkan jumlah uang Andi: ");
//        string inputUang = Console.ReadLine();

//        if (int.TryParse(inputUang, out uangAndi))
//            break;
//        else
//            Console.WriteLine("Input tidak valid. Masukkan angka.");
//    }

//    // Meminta input harga baju
//    while (true)
//    {
//        Console.Write("Masukkan harga baju (pisahkan dengan koma): ");
//        string inputHargaBaju = Console.ReadLine();

//        string[] hargaBajuArr = inputHargaBaju.Split(',');

//        if (IsValidInput(hargaBajuArr))
//        {
//            hargaBaju = Array.ConvertAll(hargaBajuArr, int.Parse);
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Input tidak valid. Masukkan angka.");
//        }
//    }

//    // Meminta input harga celana
//    while (true)
//    {
//        Console.Write("Masukkan harga celana (pisahkan dengan koma): ");
//        string inputHargaCelana = Console.ReadLine();

//        string[] hargaCelanaArr = inputHargaCelana.Split(',');

//        if (IsValidInput(hargaCelanaArr))
//        {
//            hargaCelana = Array.ConvertAll(hargaCelanaArr, int.Parse);
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Input tidak valid. Masukkan angka.");
//        }
//    }

//    int totalHargaTerbaik = CariTotalHargaTerbaik(uangAndi, hargaBaju, hargaCelana);

//    Console.WriteLine("Total harga terbaik: " + totalHargaTerbaik);
//}

//static bool IsValidInput(string[] inputArr)
//{
//    foreach (string input in inputArr)
//    {
//        if (!int.TryParse(input, out _))
//            return false;
//    }
//    return true;
//}

//static int CariTotalHargaTerbaik(int uang, int[] hargaBaju, int[] hargaCelana)
//{
//    int totalHargaTerbaik = 0;

//    foreach (int baju in hargaBaju)
//    {
//        foreach (int celana in hargaCelana)
//        {
//            int totalHarga = baju + celana;

//            if (totalHarga <= uang && totalHarga > totalHargaTerbaik)
//            {
//                totalHargaTerbaik = totalHarga;
//            }
//        }
//    }

//    return totalHargaTerbaik;
//}


//static void number5()
//{
//    Console.Write("Masukkan angka-angka (pisahkan dengan spasi): ");
//    string inputArr = Console.ReadLine();
//    string[] arrStrings = inputArr.Split(' ');
//    int[] arr = Array.ConvertAll(arrStrings, int.Parse);

//    Console.Write("Masukkan jumlah rotasi: ");
//    int rot = Convert.ToInt32(Console.ReadLine());

//    RotateArray(arr, rot);

//    Console.WriteLine("Hasil perubahan posisi:");
//    PrintRotations(arr);

//    Console.ReadLine();
//}

//static void RotateArray(int[] arr, int rot)
//{
//    int n = arr.Length;

//    // Menggunakan modulus rotasi agar rotasi yang melebihi panjang array tidak menjadi masalah
//    rot = rot % n;

//    // Memutar elemen-elemen array
//    for (int i = 0; i < rot; i++)
//    {
//        int temp = arr[0];

//        for (int j = 0; j < n - 1; j++)
//        {
//            arr[j] = arr[j + 1];
//        }

//        arr[n - 1] = temp;
//    }
//}

//static void PrintRotations(int[] arr)
//{
//    int n = arr.Length;

//    for (int i = 0; i < n; i++)
//    {
//        Console.Write("Index ke-" + i + " adalah: ");
//        for (int j = 0; j < n; j++)
//        {
//            Console.Write(arr[j] + " ");
//        }
//        Console.WriteLine();

//        // Memutar elemen-elemen array untuk langkah rotasi selanjutnya
//        int temp = arr[0];

//        for (int j = 0; j < n - 1; j++)
//        {
//            arr[j] = arr[j + 1];
//        }

//        arr[n - 1] = temp;
//    }
//}



////static void number6()
////{
////Console.Write("Masukkan angka-angka (pisahkan dengan spasi): ");
////string inputArr = Console.ReadLine();
////string[] arrStrings = inputArr.Split(' ');
////int[] arr = Array.ConvertAll(arrStrings, int.Parse);

////Console.Write("Masukkan jumlah rotasi: ");
////int rot = Convert.ToInt32(Console.ReadLine());

////RotateArray(arr, rot);

////Console.WriteLine("Hasil perubahan posisi:");
////PrintArray(arr);

////Console.ReadLine();
////}

////static void RotateArray(int[] arr, int rot)
////{
////    int n = arr.Length;

////    // Menggunakan modulus rotasi agar rotasi yang melebihi panjang array tidak menjadi masalah
////    rot = rot % n;

////    // Memutar elemen-elemen array
////    for (int i = 0; i < rot; i++)
////    {
////        int temp = arr[0];

////        for (int j = 0; j < n - 1; j++)
////        {
////            arr[j] = arr[j + 1];
////        }

////        arr[n - 1] = temp;
////    }
////}

////static void PrintArray(int[] arr)
////{
////    for (int i = 0; i < arr.Length; i++)
////    {
////        Console.Write(arr[i] + " ");
////    }
////    Console.WriteLine();
////}

//static void number5()
//{
//    Console.WriteLine(" Root Array ");
//    Console.Write(" Masukkan Array Awal: ");
//    string[] inputAwal = Console.ReadLine().Split(",");

//    Console.Write("Masukkan Rotasi: ");
//    int rotasi = int.Parse(Console.ReadLine());

//    string[] hold = new string[1];

//    for (int i = 0; i < rotasi; i++)
//    {
//        hold[0] = inputAwal[0];

//        for (int j = 0; j < inputAwal.Length - 1; j++)
//        {
//            inputAwal[j] = inputAwal[j + 1];
//        }

//        inputAwal[inputAwal.Length - 1] = hold[0];

//        Console.WriteLine($"{i + 1}: {string.Join(",", inputAwal)}");
//    }
//}


//static void number6()
//{

//    Console.Write("Masukkan jumlah angka: ");
//    int n = Convert.ToInt32(Console.ReadLine());

//    Console.Write("Masukkan angka-angka (pisahkan dengan koma): ");
//    string input = Console.ReadLine();
//    string[] inputArr = input.Split(',');
//    int[] arr = Array.ConvertAll(inputArr, int.Parse);

//    BubbleSort(arr);

//    Console.WriteLine("Hasil pengurutan:");
//    PrintArray(arr);

//    Console.ReadLine();
//}

//static void BubbleSort(int[] arr)
//{
//    int n = arr.Length;
//    for (int i = 0; i < n - 1; i++)
//    {
//        for (int j = 0; j < n - i - 1; j++)
//        {
//            if (arr[j] > arr[j + 1])
//            {
//                int temp = arr[j];
//                arr[j] = arr[j + 1];
//                arr[j + 1] = temp;
//            }
//        }
//    }
//}

//static void PrintArray(int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        Console.Write(arr[i]);
//        if (i < arr.Length - 1)
//        {
//            Console.Write(", ");
//        }
//    }
//    Console.WriteLine();
//}


