using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp
{
    public class GraphMutationResponse
    {
        /// <summary>
        /// List of returned values with the mutation call.
        /// </summary>
        public IEnumerable<GraphKeyValuePair> Values { get; set; }

        /// <summary>
        /// List of errors returned by the mutation call. Will be an empty list if none.
        /// </summary>
        public IEnumerable<GraphUserError> UserErrors { get; set; }
    }
}
