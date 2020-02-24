using System.Collections.Generic;

namespace ShopifySharp.Filters
{
    public class UnpaginatedListFilter : Parameterizable, IUnpaginatedListFilter
    {
        public IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            return base.ToParameters();
        }
    }
}