namespace FactoryMethod.RealWorld
{
    class Course
    {
        public string Name;
        public int Length;

        public override string ToString()
        {
            return "Name: " + Name + " " + "Length: " + Length;
        }
    }
}
