
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Summa(2, 3, 4, 5, 5, 5, 8, 0, 89));
        Program program = new Program();
    }

    public static int Summa(params int[] nums)
    {
        return nums.Sum();
    }


    // method overloading deyiladi
    /* public int Number(int a, int b)
     {
         return a + b;
     }
     public int Number(int a, int b, int c)
     {
         return a + b + c;
     }
     public int Number(int a, int b, int c, int d)
     {
         return a + b + c + d;
     }
     public int Number(int a, int b, int c, int d, int e)
     {
         return a + b + c + d + e;
     }
     public int Number(int a, int b, int c, int d, int e, int r)
     {
         return a + b + c + d + e + r;
     }
     public int Number(int a, int b, int c, int d, int e, int r, int f)
     {
         return a + b + c + d + e + r + f;

     }*/

}