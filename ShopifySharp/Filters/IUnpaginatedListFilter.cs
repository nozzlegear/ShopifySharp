using System.Collections.Generic;

namespace ShopifySharp.Filters
{
    // TODO: rename this to IListFilter, and rename the existing IListFilter to IPaginatedListFilter
    public interface IUnpaginatedListFilter<T>
    {
        IEnumerable<KeyValuePair<string, object>> ToQueryParameters();
    }
}