using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// A generic class for filtering the results of a .CountAsync command.
    /// </summary>
    public class CountFilter : Parameterizable, ICountFilter
    {
    }
}
