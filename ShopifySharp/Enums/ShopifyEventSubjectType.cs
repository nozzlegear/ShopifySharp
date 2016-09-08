using Newtonsoft.Json;
using ShopifySharp.Converters;
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
        /// Event related to a Article.
        /// </summary>
        [EnumMember(Value = "Article")]
        Article,

        /// <summary>
        /// Event related to an Blog.
        /// </summary>
        [EnumMember(Value = "Blog")]
        Blog,

        /// <summary>
        /// Event related to a Collection.
        /// </summary>
        [EnumMember(Value = "Collection")]
        Collection,

        /// <summary>
        /// Event related to a Comment.
        /// </summary>
        [EnumMember(Value = "Comment")]
        Comment,

        /// <summary>
        /// Event related to a Order.
        /// </summary>
        [EnumMember(Value = "Order")]
        Order,

        /// <summary>
        /// Event related to a Page.
        /// </summary>
        [EnumMember(Value = "Page")]
        Page,

        /// <summary>
        /// Event related to a Product.
        /// </summary>
        [EnumMember(Value = "Product")]
        Product,

        /// <summary>
        /// Event related to a ApiPermission.
        /// </summary>
        [EnumMember(Value = "ApiPermission")]
        ApiPermission
    }
}
