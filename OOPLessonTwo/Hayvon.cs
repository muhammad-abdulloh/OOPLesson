namespace OOPLessonTwo
{
    internal class Hayvon : Animal
    {
        public Hayvon(string hayvon) : base(hayvon)
        {

        }

        Hayvon hayvon = new Hayvon("Mushuk");

        int a = 4;
        int b = 5;

        int sum = 0;

        public void Davay()
        {
            sum = a + b;
            hayvon.GetNumber();
        }

    }
}
