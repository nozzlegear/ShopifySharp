using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp
{
    public class GraphKeyValuePair
    {
        /// <summary>
        /// In the format gid://...
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Will be the most important value for whatever you are calling, i.e. the metafield value in a metafield call.
        /// </summary>
        public object Value { get; set; }
    }
}
