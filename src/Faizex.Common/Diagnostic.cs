using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;

namespace Faizex.Common
{
  /// <summary>
  /// The <see cref="Diagnostic"/> class for code error handling.
  /// </summary>
  public static class Diagnostic
  {
    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> if the specified parameter is null.
    /// </summary>
    /// <param name="obj">The object.</param>
    /// <param name="message">The message.</param>
    public static void ThrowIfNull(object obj, string message = "")
    {
      if (!obj.IsNull())
        return;

      if (message.IsNullOrEmpty())
        throw new ArgumentNullException($"Provided parameter {nameof(obj)} cannot be null.");
      throw new ArgumentNullException(nameof(obj), message);
    }

    /// <summary>
    /// Throws an <see cref="ArgumentNullException"/> if the specified parameter is null.
    /// </summary>
    /// <param name="str">The string.</param>
    /// <param name="message">The message.</param>
    public static void ThrowIfNullOrEmpty(string str, string message = "")
    {
      if (!str.IsNullOrEmpty())
        return;

      if (message.IsNullOrEmpty())
        throw new ArgumentNullException($"Provided parameter {nameof(str)} cannot be null or empty.");
      throw new ArgumentNullException(nameof(str), message);
    }

    /// <summary>
    /// Traces an error using the system <see cref="Trace"></see> class.
    /// </summary>
    /// <param name="message">The message to trace.</param>
    /// <param name="e">The exception to trace.</param>
    /// <param name="methodName">The method name.</param>
    /// <param name="filePath">The class name.</param>
    /// <param name="lineNumber">The occurring issue's line number.</param>
    public static void TraceError(string message, Exception e = null, [CallerMemberName] string methodName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
      if (e.IsNull())
        Trace.TraceError(message);
      else
        Trace.TraceError(message, e);
    }

    /// <summary>
    /// Traces an error using the system <see cref="Trace"/> class.
    /// </summary>
    /// <param name="e">The exception.</param>
    /// <param name="key">The key or id.</param>
    /// <param name="methodName">The method name.</param>
    /// <param name="filePath">The class name.</param>
    /// <param name="lineNumber">The occurring issue's line number.</param>
    public static void TraceError(Exception e, string key = "", [CallerMemberName] string methodName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
    {
      var fileName = Path.GetFileName(filePath);
      if (key.IsNullOrEmpty())
        Trace.TraceError($"ERROR: An unexpected error occurred while calling {methodName} in {fileName} with exception {e}");
      Trace.TraceError($"ERROR: An unexpected error occurred while calling {methodName} in {fileName} with key {key} with exception {e}");
    }
  }
}