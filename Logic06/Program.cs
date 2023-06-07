using Logic06;
abstractclass();

Console.ReadKey();


static void ObjectClass()
{]
    Mobil mobil = new Mobil() { nama = "Ferrari", kecepatan = 0, bensin = 0 };

}

static void abstractclass()
{
    Console.WriteLine(" Masukan Input x : ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine(" Masukan Input y : ");
    int y = int.Parse(Console.ReadLine());

    TestTurunan kal = new TestTurunan();
    int jumlah = kal.jumlah(x, y);
    int kurang = kal.kurang(x, y);

    Console.WriteLine($" hasil {x} + {y} = {jumlah} ");
    Console.WriteLine($" hasil {x} + {y} = {kurang} ");
}