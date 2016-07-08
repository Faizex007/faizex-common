using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Faizex.Common
{
  /// <summary>
  /// A dictionary helper class.
  /// </summary>
  public static class DictionaryHelper
  {
    /// <summary>
    /// Merges the current <see cref="IDictionary{TKey,TValue}"/> data to a new <see cref="IDictionary{TKey,TValue}"/>.
    /// </summary>
    /// <typeparam name="TKey">The key.</typeparam>
    /// <typeparam name="TValue">The value.</typeparam>
    /// <param name="dict">The dictionary.</param>
    /// <param name="data">The data</param>
    /// <returns>IDictionary{TKey, TValue}</returns>
    public static IDictionary<TKey, TValue> Merge<TKey, TValue>(this IDictionary<TKey, TValue> dict, IDictionary<TKey, TValue> data)
    {
      foreach (var item in data.Where(item => !dict.ContainsKey(item.Key)))
        dict.Add(item.Key, item.Value);

      return dict;
    }

    /// <summary>
    /// Converts the object properties to a dictionary.
    /// </summary>
    /// <param name="obj">The object.</param>
    /// <returns>IDictionary{string, object}</returns>
    public static IDictionary<string, object> ToDictionary(this object obj)
    {
      return obj.ToDictionary<object>();
    }

    /// <summary>
    /// Converts the object's properties to a dictionary
    /// </summary>
    /// <typeparam name="T">The type.</typeparam>
    /// <param name="obj">The object.</param>
    /// <returns>IDictionary{string, T}</returns>
    public static IDictionary<string, T> ToDictionary<T>(this object obj)
    {
      var dictionary = new Dictionary<string, T>();
      foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(obj))
      {
        var value = property.GetValue(obj);
        if (value is T)
          dictionary.Add(property.Name, (T)value);
        else
        {
          var newValue = (T)Convert.ChangeType(value, typeof(T));
          dictionary.Add(property.Name, newValue);
        }
      }

      return dictionary;
    }
  }
}