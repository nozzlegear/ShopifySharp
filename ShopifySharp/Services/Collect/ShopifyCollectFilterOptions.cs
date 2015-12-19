using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyCollectFilterOptions : ShopifyFilterOptions
    {

        public long? product_id { get; set; }
        public long? collection_id { get; set; }

    }
}
