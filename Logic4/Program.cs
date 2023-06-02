//InisialisasiArray();
//Array2Dimensi();
//InisialisasiList();
//using Logic04;
ClassStudent();

//datetime();
//Parsing();

Console.ReadKey();


static void Parsing()
{
    Console.WriteLine("Parsing");
    Console.WriteLine("=======");

    string dateString = "06/30/2023";
    DateTime date = DateTime.Parse(dateString);

    Console.WriteLine(date);
}


static void datetime()
{
    Console.WriteLine("Date and Time");
    Console.WriteLine("=============");

    DateTime dt1 = new DateTime(); // 01/01/0001 00.00.00.000
    Console.WriteLine(dt1);

    DateTime dtNow = DateTime.Now;//Date Tgl dan Waktu hari ini
    Console.WriteLine(dtNow);

    DateTime dt2 = new DateTime(2023, 6, 2);
    Console.WriteLine(dt2);

    DateTime dt3 = new DateTime(2020, 6, 2, 13, 20, 45);
    Console.WriteLine(dt3);

}


static void InisialisasiList()
{
    List<string> list = new List<string>()
    {
        "John Wick",
        "Jamie Welton",
        "Red Eyes"
    };
    list.Add("Luffy");

    Console.WriteLine(string.Join(" , ", list));
}



static void ClassStudent()
{
    Console.WriteLine("-== CALL CLASS STUDENT ==-");
    List<Student> students = new List<Student>()
    {
        new Student(){Id = 1, Name = "John Doe"},
        new Student(){Id = 2, Name = "Jane Doe"},
        new Student(){Id = 3, Name = "Joe Doe"},

    };
    Console.WriteLine($"The length of the Student data list = {students.Count}");
    foreach (Student student in students)
    {
        Console.WriteLine($"Id : {student.Id} , Name : {student.Name}");
    }
}

static void Array2Dimensi()
{
    Console.WriteLine("Array 2 Dimensi");
    Console.WriteLine("===============");

    int[,] array = new int[3, 3]
    {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
    };

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine(array[i, j]);
        }
        Console.WriteLine();
    }
}

static void MengaksesElemenArray()
{
    Console.WriteLine("Mengakses Elemen Array");
    Console.WriteLine("======================");

    int[] IntStaticArray = new int[3];
    IntStaticArray[0] = 1;
    IntStaticArray[1] = 2;
    IntStaticArray[2] = 3;

    Console.WriteLine(IntStaticArray[0]);
    Console.WriteLine(IntStaticArray[1]);
    Console.WriteLine(IntStaticArray[2]);

    int[] array = { 2, 4, 5 };
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }

    string[] strArray = new string[] { "Mahes Chand, Jamie Welton, Jackie" };
    foreach(string item in strArray)
    {
        Console.WriteLine(item);
    }
}

static void InisialisasiArray()
{
    Console.WriteLine("Inisialisasi Array");
    Console.WriteLine("------------------");
    // Cara 1
    int[] array = new int[5];
    //array = new int[] {1, 2, 3, 4, 5 };
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Masukan data ke { i + 1} ");
        array[i] = int.Parse( Console.ReadLine() );
    }
    // Cara 2
    int [] array2 = new int[5] { 1, 2, 3, 4, 5 };
    //Cara 3
    int[] array3 = new int[5] { 1, 2, 3, 4, 5 };
    //Cara 4 
    int[] array4 = { 1, 2, 3, 4, 5 };
    //Cara 5
    int[] array5;
    array5 = new int[5] { 1, 2, 3, 4, 5 };

    Console.WriteLine(string.Join(" , ", array));
    Console.WriteLine(string.Join(" , ", array2));
    Console.WriteLine(string.Join(" , ", array3));
    Console.WriteLine(string.Join(" , ", array4));
    Console.WriteLine(string.Join(" , ", array5));
}