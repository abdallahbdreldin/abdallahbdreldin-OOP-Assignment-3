namespace Generics.Entities
{
    public class Course
    {
        private static int _counter = 0;
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public Course(string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Course name cannot be null or empty.", nameof(name));
            if (price < 0)
                throw new ArgumentOutOfRangeException(nameof(price), "Price cannot be negative.");
            Id = ++_counter;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Course(Id={Id}, Name={Name}, Price={Price})";
        }
    }
}
