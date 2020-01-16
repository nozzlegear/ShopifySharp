namespace ShopifySharp.Filters
{
    public interface IListFilter
    {
        /// <summary>
        /// A unique ID used to access a page of results. Must be present to list more than the first page of results. 
        /// </summary>
        string PageInfo { get; set; }

        /// <summary>
        /// The number of items which should be returned. Default is 50, maximum is 250.
        /// </summary>
        int? Limit { get; set; }
    }
}
