using System.Collections.Generic;

namespace ShopifySharp.Filters
{
    public class UnpaginatedListFilter : Parameterizable, IUnpaginatedListFilter
    {
        public IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            var a = base.ToParameters();
            throw new System.NotImplementedException();
        }
    }
}