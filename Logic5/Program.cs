
//PadLeft();
//RekursifDesc();
RekursifAsc();


Console.ReadKey();

static void PadLeft()
{
    Console.Write(" masukan input : ");
    int input = int.Parse(Console.ReadLine());
    Console.Write("masukan panjang karakter : ");
    int panjang = int.Parse(Console.ReadLine());
    Console.Write("masukan char : ");
    char chars = char.Parse(Console.ReadLine());

    DateTime date = DateTime.Now;

    string code = "";
    code = date.ToString("yy") + date.ToString("MM") + input.ToString().PadLeft(panjang, chars);
    //code = date.ToString("yy") + date.ToString("MM") + input.ToString().PadRight(panjang, chars);

    Console.Write($"hasil PadLeft : {code}");

}

static void RekursifDesc()
{
    Console.WriteLine("Masukkan angka mulai: ");
    int start = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Masukkan angka berakhir: ");
    int end = Convert.ToInt32(Console.ReadLine());

    PrintNumbers(start, end);
}

static void PrintNumbers(int start, int end)
{
    if (start <= end)
    {
        Console.Write(" " +start);
        PrintNumbers(start + 1, end);
    }
}


static void RekursifAsc()
{
    Console.WriteLine("Masukkan angka mulai: ");
    int startAsc = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Masukkan angka berakhir: ");
    int endAsc = Convert.ToInt32(Console.ReadLine());

    PrintNumbersAsc(startAsc, endAsc);
}

static void PrintNumbersAsc(int startAsc, int endAsc)
{
    if (startAsc <= endAsc)
    {
        Console.Write(" " + startAsc);
        PrintNumbersAsc(startAsc + 1, endAsc);
    }
}