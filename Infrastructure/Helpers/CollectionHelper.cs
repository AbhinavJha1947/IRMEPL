using Microsoft.Extensions.Logging;
using System.Collections;
using System.Linq;

namespace Infrastructure.Helpers
{
    public static class CollectionHelper
    {
        private static readonly ILogger _logger = 
            Microsoft.Extensions.Logging.LoggerFactory.Create(builder => builder.AddConsole()).CreateLogger("CollectionHelper");

        public static bool IsNullOrEmpty<T>(IEnumerable<T>? collection)
        {
            try
            {
                return collection == null || !collection.Any();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error checking if collection is null or empty");
                return true;
            }
        }

        public static bool IsNullOrEmpty(IEnumerable? collection)
        {
            try
            {
                return collection == null || !collection.Cast<object>().Any();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error checking if collection is null or empty");
                return true;
            }
        }

        public static int SafeCount<T>(IEnumerable<T>? collection)
        {
            try
            {
                return collection?.Count() ?? 0;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting collection count");
                return 0;
            }
        }

        public static T? SafeFirstOrDefault<T>(IEnumerable<T>? collection) where T : class
        {
            try
            {
                return collection?.FirstOrDefault();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting first element from collection");
                return default;
            }
        }

        public static T? SafeFirstOrDefault<T>(IEnumerable<T>? collection, Func<T, bool> predicate) where T : class
        {
            try
            {
                return collection?.FirstOrDefault(predicate);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting first element from collection with predicate");
                return default;
            }
        }

        public static List<T> SafeToList<T>(IEnumerable<T>? collection)
        {
            try
            {
                return collection?.ToList() ?? new List<T>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error converting collection to list");
                return new List<T>();
            }
        }

        public static T[] SafeToArray<T>(IEnumerable<T>? collection)
        {
            try
            {
                return collection?.ToArray() ?? Array.Empty<T>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error converting collection to array");
                return Array.Empty<T>();
            }
        }

        public static IEnumerable<T> SafeWhere<T>(IEnumerable<T>? collection, Func<T, bool> predicate)
        {
            try
            {
                return collection?.Where(predicate) ?? Enumerable.Empty<T>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error filtering collection");
                return Enumerable.Empty<T>();
            }
        }

        public static IEnumerable<TResult> SafeSelect<T, TResult>(IEnumerable<T>? collection, Func<T, TResult> selector)
        {
            try
            {
                return collection?.Select(selector) ?? Enumerable.Empty<TResult>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error projecting collection");
                return Enumerable.Empty<TResult>();
            }
        }

        public static void SafeForEach<T>(IEnumerable<T>? collection, Action<T> action)
        {
            try
            {
                if (collection != null)
                {
                    foreach (var item in collection)
                    {
                        action(item);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error iterating through collection");
            }
        }

        public static Dictionary<TKey, TValue> SafeToDictionary<T, TKey, TValue>(
            IEnumerable<T>? collection, 
            Func<T, TKey> keySelector, 
            Func<T, TValue> valueSelector) where TKey : notnull
        {
            try
            {
                return collection?.ToDictionary(keySelector, valueSelector) ?? new Dictionary<TKey, TValue>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error converting collection to dictionary");
                return new Dictionary<TKey, TValue>();
            }
        }

        public static IEnumerable<T> SafeOrderBy<T, TKey>(IEnumerable<T>? collection, Func<T, TKey> keySelector)
        {
            try
            {
                return collection?.OrderBy(keySelector) ?? Enumerable.Empty<T>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error ordering collection");
                return Enumerable.Empty<T>();
            }
        }

        public static IEnumerable<T> SafeOrderByDescending<T, TKey>(IEnumerable<T>? collection, Func<T, TKey> keySelector)
        {
            try
            {
                return collection?.OrderByDescending(keySelector) ?? Enumerable.Empty<T>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error ordering collection descending");
                return Enumerable.Empty<T>();
            }
        }
    }
}
