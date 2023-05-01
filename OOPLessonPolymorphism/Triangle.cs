namespace OOPLessonPolymorphism
{
    internal class Triangle : Shape
    {
        public override int Perimeter(int p)
        {
            throw new NotImplementedException();
        }
        public override int Area(int s)
        {
            return base.Area(s);
        }
    }
}
