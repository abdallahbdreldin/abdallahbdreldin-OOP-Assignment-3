namespace Generics.Entities
{
    public class Student
    {
        private static int _counter = 0;
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Student(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Student name cannot be null or empty.",nameof(name));

            Id = ++_counter;
            Name = name;
        }

        public override string ToString()
        {
            return $"Student(Id={Id}, Name={Name})";
        }
    }
}
