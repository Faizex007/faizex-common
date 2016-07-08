using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Faizex.Common
{
  /// <summary>
  /// An async helper class.
  /// </summary>
  public static class Async
  {
    /// <summary>
    /// Configures a false awaiter used to await this <see cref="Task"/>.
    /// </summary>
    /// <param name="task">The task to await.</param>
    /// <returns>ConfiguredTaskAwaitable</returns>
    public static ConfiguredTaskAwaitable AwaitFalse(this Task task)
    {
      return task.ConfigureAwait(false);
    }

    /// <summary>
    /// Configures a false awaiter used to await this <see cref="Task"/>.
    /// </summary>
    /// <param name="task">The task to await.</param>
    /// <returns>ConfiguredTaskAwaitable</returns>
    public static ConfiguredTaskAwaitable<TResult> AwaitFalse<TResult>(this Task<TResult> task)
    {
      return task.ConfigureAwait(false);
    }

    /// <summary>
    /// Configures a true awaiter used to await this <see cref="Task"/>.
    /// </summary>
    /// <param name="task">The task to await.</param>
    /// <returns>ConfiguredTaskAwaitable</returns>
    public static ConfiguredTaskAwaitable AwaitTrue(this Task task)
    {
      return task.ConfigureAwait(true);
    }

    /// <summary>
    /// Configures a true awaiter used to await this <see cref="Task"/>.
    /// </summary>
    /// <param name="task">The task to await.</param>
    /// <returns>ConfiguredTaskAwaitable</returns>
    public static ConfiguredTaskAwaitable<TResult> AwaitTrue<TResult>(this Task<TResult> task)
    {
      return task.ConfigureAwait(true);
    }
  }
}