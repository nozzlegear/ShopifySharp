using Newtonsoft.Json;
using System.Collections.Generic;
using System.Reflection;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// A generic class for filtering the results of a .ListAsync command.
    /// </summary>
    public class ListFilter : IListFilter
    {
        public string PageInfo { get; set; }

        public int? Limit { get; set; }
    }
}
