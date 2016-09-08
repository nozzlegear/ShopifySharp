using Newtonsoft.Json;
using ShopifySharp.Converters;
using ShopifySharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// An enum that indicates an event subject type <see cref="ShopifyEvent"/>
    /// </summary>
    [JsonConverter(typeof(NullableEnumConverter<ShopifyEventSubjectType>))]
    public enum ShopifyEventSubjectType
    {
        /// <summary>
        /// Event related to a Product.
        /// </summary>
        [EnumMember(Value = "Product")]
        Product,

        /// <summary>
        /// Event related to an Order.
        /// </summary>
        [EnumMember(Value = "Order")]
        Order

            // TODO: Complete
    }
}
