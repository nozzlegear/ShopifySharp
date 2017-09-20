using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Tests.Extensions
{
    /// <summary>
    /// Extensions which provide assertions to objects that can be empty (strings and IEnumerables).
    /// </summary>
    public static class EmptyExtensions
    {
        public static void NullOrEmpty<T>(this IEnumerable<T> source)
        {
            if (source == null || source.Count() == 0)
            {
                return;
            }

            throw new NotNullOrEmptyException(source);
        }

        public static void NotNullOrEmpty<T>(this IEnumerable<T> source)
        {
            if (source == null || source.Count() == 0)
            {
                throw new NullOrEmptyException(source);
            }
        }
    }

    public class NotNullOrEmptyException : Exception
    {
        public object Target { get; }

        public NotNullOrEmptyException(object target) : base($"Target was not null or empty.")
        {
            this.Target = target;
        }   
    }

    public class NullOrEmptyException : Exception
    {
        public object Target { get; }

        public NullOrEmptyException(object target) : base("Target was null or empty.")
        {
            this.Target = target;
        }
    }
}