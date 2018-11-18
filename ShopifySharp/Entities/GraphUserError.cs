using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp
{
    public class GraphUserError
    {
        /// <summary>
        /// The field associated with the error.
        /// </summary>
        [JsonProperty("field")]
        public string Field { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
