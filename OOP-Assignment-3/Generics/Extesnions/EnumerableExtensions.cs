using Generics.Interfaces;

namespace Generics.Extesnions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Page<T>(
            this IEnumerable<T> source,
            int pageNumber,
            int pageSize)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (pageNumber <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(pageNumber),
                    "Page number must be greater than zero.");

            if (pageSize <= 0)
                throw new ArgumentOutOfRangeException(
                    nameof(pageSize),
                    "Page size must be greater than zero.");

            int startIndex = (pageNumber - 1) * pageSize;
            int currentIndex = 0;

            foreach (var item in source)
            {
                if (currentIndex >= startIndex &&
                    currentIndex < startIndex + pageSize)
                {
                    yield return item;
                }

                if (currentIndex >= startIndex + pageSize)
                    yield break;

                currentIndex++;
            }
        }

        public static T? FindById<T>(this IEnumerable<T> source, int id)
            where T : IHasId
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            foreach (var item in source)
            {
                if (item.Id == id)
                    return item;
            }

            return default;
        }

        public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(
            this IEnumerable<T> source)
            where T : IHasId
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var dictionary = new Dictionary<int, T>();

            foreach (var item in source)
            {
                dictionary.Add(item.Id, item);
            }

            return dictionary;
        }
    }
}
