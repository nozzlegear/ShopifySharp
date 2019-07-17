using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// Useful methods for services./>
    /// </summary>    
    public static class ShopifyServiceExtensions
    {
        /// <summary>
        /// Lists of all of the results.
        /// </summary>
        public static async Task<IEnumerable<TShopifyObject>> ListAllAsync<TShopifyObject, TListFilter>(this IListAsync<TShopifyObject, TListFilter> service)
            where TShopifyObject : ShopifyObject
            where TListFilter : ListFilter, new()
        {
            return await service.ListAllAsync(new TListFilter());
        }

        /// <summary>
        /// Lists of all of the results.
        /// </summary>
        /// <param name="options">Options for filtering the list.</param>
        /// <returns>The list of orders matching the filter.</returns>
        public static async Task<IEnumerable<TShopifyObject>> ListAllAsync<TShopifyObject, TListFilter>(this IListAsync<TShopifyObject, TListFilter> service, TListFilter options)
            where TShopifyObject : ShopifyObject
            where TListFilter : ListFilter, new()
        {
            options = options.CloneViaJson(); // To avoid mutating the parameter
            options.Page = options.Page ?? 1;
            options.Limit = options.Limit ?? 250;

            var result = new List<TShopifyObject>();

            do
            {
                try
                {
                    var items = await service.ListAsync(options);

                    if (!items.Any())
                    {
                        return result;
                    }

                    result.AddRange(items);
                    options.Page++;
                }
                catch (ShopifyRateLimitException)
                {
                    await Task.Delay(TimeSpan.FromSeconds(2));
                }
            } while (true);
        }
    }
}