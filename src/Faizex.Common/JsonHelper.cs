using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Faizex.Common
{
  /// <summary>
  /// A JSON helper class.
  /// </summary>
  public static class JsonHelper
  {
    /// <summary>
    /// Deserializes a JSON <see cref="string"/> into an <see cref="object"/>.
    /// </summary>
    /// <typeparam name="T">The type.</typeparam>
    /// <param name="str">The string.</param>
    /// <returns>T</returns>
    public static T FromJson<T>(this string str)
    {
      if (!str.IsJson())
        throw new ArgumentException($"The parameter {nameof(str)} must be in JSON format.");

      return JsonConvert.DeserializeObject<T>(str);
    }

    /// <summary>
    /// Deserializes a <see cref="Stream"/> into an <see cref="object"/>.
    /// </summary>
    /// <typeparam name="T">The type.</typeparam>
    /// <param name="stream">The stream.</param>
    /// <returns>T</returns>
    public static T FromStream<T>(this Stream stream)
    {
      string item;
      using (var reader = new StreamReader(stream))
        item = reader.ReadToEnd();

      return FromJson<T>(item);
    }

    /// <summary>
    /// Checks if a <see cref="string"/> is in JSON format.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <returns>bool</returns>
    public static bool IsJson(this string str)
    {
      try
      {
        var obj = JToken.Parse(str);
        return obj != null;
      }
      catch (Exception)
      {
        return false;
      }
    }

    /// <summary>
    /// Serializes an <see cref="object"/> into an indented JSON <see cref="string"/>.
    /// </summary>
    /// <param name="obj">The object.</param>
    /// <returns>string</returns>
    public static string Pretty(this object obj)
    {
      return JsonConvert.SerializeObject(obj, Formatting.Indented);
    }

    /// <summary>
    /// Serializes an <see cref="object"/> into a JSON <see cref="string"/>.
    /// </summary>
    /// <param name="obj">The object.</param>
    /// <returns>string</returns>
    public static string ToJson(this object obj)
    {
      return JsonConvert.SerializeObject(obj);
    }

    /// <summary>
    /// Serializes an <see cref="object"/> into a JSON <see cref="string"/>.
    /// </summary>
    /// <param name="obj">The object.</param>
    /// <param name="settings">The settings.</param>
    /// <returns>string</returns>
    public static string ToJson(this object obj, JsonSerializerSettings settings)
    {
      return JsonConvert.SerializeObject(obj, settings ?? new JsonSerializerSettings());
    }

    /// <summary>
    /// Serializes an <see cref="object"/> into a minified JSON <see cref="string"/>, ignoring null values.
    /// </summary>
    /// <param name="obj">The object.</param>
    /// <returns>string</returns>
    public static string ToJsonMin(this object obj)
    {
      var settings = new JsonSerializerSettings
      {
        NullValueHandling = NullValueHandling.Ignore,
        Formatting = Formatting.None
      };

      return JsonConvert.SerializeObject(obj, settings);
    }
  }
}