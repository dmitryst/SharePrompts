using System.Runtime.CompilerServices;

namespace SharePrompts.SharedKernel.Extensions;

public static class NullExtensions
{
  public static T ThrowIfNull<T>(
      this T? argument,
      string? message = default,
      [CallerArgumentExpression("argument")] string? paramName = default
  ) where T : notnull
  {
    if (argument is null)
    {
      throw new ArgumentNullException(paramName, message);
    }
    else
    {
      return argument;
    }
  }
}
