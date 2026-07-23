#nullable enable
using System;
using System.Text.RegularExpressions;
using JetBrains.Annotations;

namespace ShopifySharp.Extensions;

internal static class ExceptionExtensions
{
    extension(NotSupportedException exn)
    {
        /// <summary>
        /// Attempts to extract the offending abstract/interface type from a
        /// <see cref="NotSupportedException"/> message thrown by
        /// <see cref="System.Text.Json"/> when a type discriminator is missing, or when
        /// deserialization of a JSON payload fails due to an interface or abstract type
        /// lacking polymorphic configuration attributes.
        /// </summary>
        internal Type? GetOffendingTypeFromMessage()
        {
            var message = exn.Message;
            // Look for `type 'Namespace.InterfaceName'`
            var start = message.IndexOf("type '", StringComparison.OrdinalIgnoreCase);

            if (start < 0)
                return null;

            start += "type '".Length;
            var end = message.IndexOf('\'', start);

            if (end < 0)
                return null;

            var typeName = message.Substring(start, end - start);

            try
            {
                return Type.GetType(typeName, throwOnError: false);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Extracts details from a <see cref="NotSupportedException"/> message produced by
        /// <see cref="System.Text.Json"/> for missing type discriminators on polymorphic types.
        /// Parses the offending abstract/interface type and the JSON path, when present.
        /// </summary>
        internal string? GetOffendingPathFromMessage()
        {
            var message = exn.Message;

            if (string.IsNullOrWhiteSpace(message))
                return null;

            // Example fragments to handle:
            //   Path: $.products.edges[0].node.media.nodes[0] | LineNumber: ...
            //   Path: $.something.something.
            // We stop path capture at '|' or '.' to avoid pulling in the LineNumber/BytePosition.
            const RegexOptions rx = RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Singleline;
            var pathMatch = Regex.Match(message, @"Path:\s*([^|\.]+)", rx);

            return pathMatch.Success ? pathMatch.Groups[1].Value.Trim() : null;
        }
    }

    extension(ArgumentNullException exn)
    {
#if NETSTANDARD2_0
        public static void ThrowIfNull(object? argument, [InvokerParameterName] string? paramName = null)
        {
            if (argument is null)
                throw new ArgumentNullException(paramName);
        }
#endif
    }
}
