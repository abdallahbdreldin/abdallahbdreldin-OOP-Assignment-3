using Generics.Entities;
using Generics.Extesnions;
using Generics.Stores;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentStore = new GenericStore<Student>();
            var courseStore = new GenericStore<Course>();

            var s1 = new Student("Alice");
            var s2 = new Student("Bob");
            var s3 = new Student("Charlie");
            var s4 = new Student("Diana");
            var s5 = new Student("Eve");

            studentStore.Add(s1);
            studentStore.Add(s2);
            studentStore.Add(s3);
            studentStore.Add(s4);
            studentStore.Add(s5);

            var c1 = new Course("Math", 100m);
            var c2 = new Course("Physics", 120m);
            var c3 = new Course("History", 80m);

            courseStore.Add(c1);
            courseStore.Add(c2);
            courseStore.Add(c3);

            var studentWithId3 = studentStore.GetById(3);
            Console.WriteLine($"student by id 3: {studentWithId3}");

            var courseWithId2 = courseStore.GetById(2);
            Console.WriteLine($"course by id 2: {courseWithId2}");

            Console.WriteLine();

            try
            {
                studentStore.Add(s1); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            Console.WriteLine();

            var page2 = studentStore.GetAll().Values.Page(2, 2);
            Console.WriteLine("Students - page 2 (size 2):");
            foreach (var s in page2)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();

            // Call FindById on a plain List<Course>
            var courseList = new List<Course> { c1, c2, c3 };
            var found = courseList.FindById(2);
            Console.WriteLine($"FindById on List<Course> (id=2): {found}");

            // var invalidStore = new GenericStore<string>(); // must NOT compile
        }
    }
}
