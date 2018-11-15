namespace FactoryMethod.RealWorld
{
    class Student
    {
        public string Name { get; set; }
        public int StartYear { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " " + "StartYear: " + StartYear;
        }
    }
}