
//PerulanganWhile2();
//PerulanganWhile2();
//Foreach();
//SplitAndJoin();
//ToCharArray();
//using System.Xml.Serialization;
//ConvertStringArrayToInt();

Console.ReadKey();

static void ConvertAll()
{
    Console.WriteLine("Convert String Array to Int");
    Console.WriteLine("===============");
    Console.Write("Masukan input angka (pakai spasi) : ");
    string[] input = Console.ReadLine().Split("");

    int sum = 0;

    int [] array = Array.ConvertAll (input, int.Parse);

    foreach (int x in array)
    {
        sum += x;
    }
    Console.WriteLine($"Jumlah = {sum}");

}

//static void ConvertStringArrayToInt()
//{
//    Console.WriteLine("Convert String Array to Int");
//    Console.WriteLine("===============");
//    Console.Write("Masukan input angka (pakai spasi) : ");
//    string input = Console.ReadLine();

//    int sum = 0;

//    string[] array = input.Split(" ");

//    foreach (string str in array)
//    {
//        sum += Convert.ToInt32(str);
//    }
//    Console.WriteLine($"Jumlah = {sum}");

//}


//static void ToCharArray()
//{
//    Console.WriteLine("String To Array");
//    Console.WriteLine("===============");
//    Console.Write("Masukan Kalimat");
//    string kalimat = Console.ReadLine();

//    char[] array = kalimat.ToCharArray();

//    foreach (char x in array)
//    {
//        Console.WriteLine(x);
//    }

//    Console.WriteLine();

//    for (int i = 0; i < array.Length; i++)
//    {
//        Console.WriteLine(array[i]);
//    }

//}
//static void SubString()
//{
//    Console.WriteLine("SUB STRING");
//    Console.Write("masukin kode : ");
//    string kode =   Console.ReadLine();
//    Console.Write("masukan parameter 1 : ");
//    string para1 = Console.ReadLine();
//    Console.Write(" masukan parameter 2 : ");
//    string para2 = Console.ReadLine();

//    if( para1 == 0 )
//    {
//        Console.WriteLine($"hasil SubString =  {kode.Substring(para1)}");
//    }
//    else
//    {
//        Console.WriteLine($"hasil SubString =  {kode.Substring(para1, para2)}");
//    }
//}


//static void SplitAndJoin()
//{
//    Console.WriteLine("Split and Join");
//    Console.Write("masukan kalimat : ");
//    string kalimat = Console.ReadLine();
//    Console.Write("masukan split string : ");
//    string split = Console.ReadLine();

//    string[] kataKata = kalimat.Split(split);

//    foreach (string kata in kataKata)
//    {
//        Console.Write(kata); 

//    }
//    Console.WriteLine(string.Join(" + ", kataKata));

//    Console.WriteLine("\n");



//}




static void ContainString()
{
    Console.WriteLine("Contain String");
    Console.WriteLine("masukin kata : ");
    string kata = Console.ReadLine();
    Console.WriteLine("masukan contain : ");
    string contain = Console.ReadLine();

    if(kata.Contains(contain))
    {
        Console.WriteLine($"kata {kata} mengandung {contain}");
    }
    else
    {
        Console.WriteLine($"kata {kata} tidak mengandung {contain}");
    }
}




static void InsertString()
{
    Console.WriteLine("Insert String");
    Console.WriteLine("=============");
    Console.Write("Masukan Kata : ");
    string kata = Console.ReadLine();
    Console.Write("Masukan Index Insert : ");
    int index = int.Parse(Console.ReadLine());
    Console.Write("Masukan kata yang di Insert : ");
    string InsertKata = Console.ReadLine();

    Console.WriteLine($"{kata.Insert(index, InsertKata)}");
}


static void RemoveString()
{
    Console.WriteLine("Remove String");
    Console.WriteLine("==============");
    Console.Write("Masukan Kata : ");
    string kata = Console.ReadLine();
    Console.Write("Maukan index remove :");
    int index = int.Parse(Console.ReadLine());

    Console.WriteLine($"[kata.Remove(index)]");
}

static void Foreach()
{
    int[] array = { 89, 90, 91, 92, 93 };

    foreach (int x in array)
    { 
        Console.WriteLine(x);
    }
}

static void ForNested()
{
    for (int i = 0; i < 3; i++) // Literasi baris
    {
        for (int j = 0; j < 3; j++) // Literasi kolom
        {
            Console.Write(i + j);;;
        }
    }
}

static void Continua()
{
    for (int i = 0; i < 10; i++)
    {
        if(i == 0)
        {
            continue;
        }
    }
}

static void Break()
{

}


static void PerulanganFor()
{
    Console.WriteLine("Perulangan For");
    Console.WriteLine("==============");

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("\n");

    for ( int i = 9; i >=0; i++)
    {
        Console.WriteLine(i);
    }
}

static void PerulanganDoWhile()
{
    Console.WriteLine("Perulangan Do WHile");
    Console.WriteLine("===================");
    Console.Write("Masukan nilai : ");
    int nilai = int.Parse(Console.ReadLine());

    do
    {
        Console.WriteLine(nilai);
        nilai++;
    } while (nilai < 6 );
}


static void PerulanganWhile2()
{
    bool ulangi = true;

    Console.WriteLine("Perulangan While 2");
    Console.WriteLine("==================");
    Console.Write("Masukan nilai : ");
    int nilai = int.Parse(Console.ReadLine());

    while (ulangi)
    {
        Console.WriteLine($"Proses ke {nilai}");
        nilai++;

        Console.WriteLine("Ulangi proses ? (y/n)");
        string input = Console.ReadLine();

        if (input.ToLower() == "n")
        {
            ulangi = false;
        }

    }
}

//static void Perulangan()
//{
//    Console.WriteLine("Perulangan While");
//    Console.WriteLine("================");
//    Console.Write("Masukan nilai : ");
//    int nilai = int.Parse(Console.ReadLine());
//}