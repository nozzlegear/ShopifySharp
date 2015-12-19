using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyCollect : ShopifyObject
    {
        /// <summary>
        /// The id of the custom collection containing the product.
        /// </summary>
        public long collection_id { get; set; }

        /// <summary>
        /// The unique numeric identifier for the product in the custom collection.
        /// </summary>
        public long product_id { get; set; }

        /// <summary>
        /// States whether or not the collect is featured.
        /// </summary>
        public bool featured { get; set; }

        /// <summary>
        /// The date and time when the collect was created. The API returns this value in ISO 8601 format.
        /// </summary>
        public DateTime created_at { get; set; }

        /// <summary>
        /// The date and time when the collect was last updated. The API returns this value in ISO 8601 format.
        /// </summary>
        public DateTime updated_at { get; set; }

        /// <summary>
        /// A number specifying the manually sorted position of this product in a custom collection. The first position is 1. This value only applies when the custom collection is viewed using the Manual sort order.
        /// </summary>
        public int position { get; set; }

        /// <summary>
        /// This is the same value as position but padded with leading zeroes to make it alphanumeric-sortable.
        /// </summary>
        public string sort_value { get; set; }
    }
}
