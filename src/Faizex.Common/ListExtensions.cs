using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faizex.Common
{
  /// <summary>
  /// A list extensions class.
  /// </summary>
  public static class ListExtensions
  {
    /// <summary>
    /// Converts and add an object to an <see cref="IEnumerable{T}"/>.
    /// </summary>
    /// <typeparam name="T">The generic type T.</typeparam>
    /// <param name="obj">The object.</param>
    /// <returns>IEnumerable{T}</returns>
    public static IEnumerable<T> ToCollection<T>(this T obj)
    {
      return new List<T> { obj };
    }

    /// <summary>
    /// Asychronously converts an <see cref="IQueryable{T}"/> to a <see cref="List{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type.</typeparam>
    /// <param name="list">The list.</param>
    /// <returns>Task{List{T}}</returns>
    public static async Task<List<T>> ToListAsync<T>(this IQueryable<T> list)
    {
      return await Task.FromResult(list.ToList());
    }
  }
}