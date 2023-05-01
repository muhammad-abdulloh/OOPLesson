
using OOPLessonRepeat;

public class Program
{

    int number = 0;

    public static void Main(string[] args)
    {
        Shakl shakl = new Shakl();
        shakl.Tomon();
    }
}

public class Numbers
{
    public int Ason { get; set; }
    public int Bson { get; set; }
}

enum Hafta
{
    Dushanba = 1, //0
    Seshanba, // 
    Chorshanba,
    Payshanba,
    Juma,
    SHanba,
    Yakshanba
}
