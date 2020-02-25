using ShopifySharp.Infrastructure;
using System.Collections.Generic;

namespace ShopifySharp.Lists
{
    public interface IListResult<T>
    {
        LinkHeaderParseResult<T> LinkHeader { get; }

        IEnumerable<T> Items { get; }
    }
}