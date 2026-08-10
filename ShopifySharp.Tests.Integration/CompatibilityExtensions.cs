using JetBrains.Annotations;

namespace ShopifySharp.Tests.Integration;

/// <summary>
/// Extensions for NET472.
/// </summary>
public static class CompatibilityExtensions
{
    extension(ArgumentNullException exn)
    {
#if NET472
        public static void ThrowIfNull(object? argument, [InvokerParameterName] string? paramName = null)
        {
            if (argument is null)
                throw new ArgumentNullException(paramName);
        }
#endif
    }

    extension(ValueTask valueTask)
    {
#if NET472
        public static ValueTask CompletedTask => default;
#endif
    }
}
