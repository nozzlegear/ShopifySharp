using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyCollectService_Tests.Test_Data
{
    public class CollectCreation
    {
        /// <summary>
        /// A manual product collection needed for testing the Collect API. NOTE: This will FAIL on your store,
        /// it needs to be replaced with your own collection id. Eventually, this entire var will be
        /// deprecated when we get CustomCollection API support.
        /// </summary>
        public static long CollectionId { get; } = 27369427;

        /// <summary>
        /// Creates a new product that can be used to test the Collect API.
        /// </summary>
        /// <returns>The new product.</returns>
        public static async Task<ShopifySharp.Product> CreateProduct()
        {
            var service = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);
            var product = new ShopifySharp.Product()
            {
                CreatedAt = DateTime.UtcNow,
                Title = "Burton Custom Freestlye 151",
                Vendor = "Burton",
                BodyHtml = "<strong>Good snowboard!</strong>",
                ProductType = "Snowboard",
                Images = new List<ProductImage> { new ProductImage { Attachment = "R0lGODlhAQABAIAAAAAAAAAAACH5BAEAAAAALAAAAAABAAEAAAICRAEAOw==" } },
            };

            return await service.CreateAsync(product);
        }

        /// <summary>
        /// Deletes a product that was used to test the Collect API.
        /// </summary>
        public static async Task DeleteProduct(long id)
        {
            var service = new ProductService(Utils.MyShopifyUrl, Utils.AccessToken);

            await service.DeleteAsync(id);
        }
    }
}
