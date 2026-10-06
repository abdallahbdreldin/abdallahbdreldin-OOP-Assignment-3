using Generics.Entities;

namespace Generics.Stores
{
    public static class CourseStore
    {
        private static readonly List<Course> _courses = new();
        public static void Add(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException(nameof(course), "Course cannot be null.");
            }
            if (string.IsNullOrWhiteSpace(course.Name))
            {
                throw new ArgumentException("Course name cannot be null or empty.", nameof(course));
            }
            if (course.Price < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(course.Price), "Course price cannot be negative.");
            }
            _courses.Add(course);
        }

        public static Course? GetCourseById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero.");
            }
            for (int i = 0; i < _courses.Count; i++)
            {
                if (_courses[i].Id == id)
                {
                    return _courses[i];
                }
            }
            return null;
        }

        public static IReadOnlyList<Course> GetAllCourses()
        {
            foreach (var course in _courses)
            {
                if (course == null)
                {
                    throw new InvalidOperationException("Course list contains a null entry.");
                }
            }
            return _courses;
        }

        public static void RemoveCourseById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero.");
            }
            for (int i = 0; i < _courses.Count; i++)
            {
                if (_courses[i].Id == id)
                {
                    _courses.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
