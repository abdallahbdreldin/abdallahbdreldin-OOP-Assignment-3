using Generics.Entities;

namespace Generics.Stores
{
    public static class StudentStore
    {
        private static readonly List<Student> _students = new();
        public static void Add(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student), "Student cannot be null.");
            }
            if (string.IsNullOrWhiteSpace(student.Name))
            {
                throw new ArgumentException("Student name cannot be null", nameof(student));
            }
            _students.Add(student);
        }

        public static Student? GetStudentById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero.");
            }

            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].Id == id)
                {
                    return _students[i];
                }
            }
            return null;
        }

        public static IReadOnlyList<Student> GetAllStudents()
        {
            foreach (var student in _students)
            {
                if (student == null)
                {
                    throw new InvalidOperationException("Student list contains a null entry.");
                }
            }
            return _students;
        }

        public static void RemoveStudentById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero.");
            }
            for (int i = 0; i < _students.Count; i++)
            {
                if (_students[i].Id == id)
                {
                    _students.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
