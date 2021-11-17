using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    public class MetaField : ShopifyObject
    {
        /// <summary>
        /// The date and time when the metafield was created.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the metafield was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// Identifier for the metafield (maximum of 30 characters).
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Information to be stored as metadata. Must be either a string or an int.
        /// </summary>
        [JsonProperty("value")]
        public object Value { get; set; }

        /// <summary>
        /// The metafield's information type. See https://shopify.dev/apps/metafields/definitions/types for a full list of types.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// States whether the information in the value is stored as a 'string' or 'integer.'
        /// </summary>
        [JsonProperty("value_type")]
        [Obsolete("ValueType is deprecated and replaced by Type.")]
        public string ValueType { get; set; }

        /// <summary>
        /// Container for a set of metadata. Namespaces help distinguish between metadata you created and metadata created by another individual with a similar namespace (maximum of 20 characters).
        /// </summary>
        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        /// <summary>
        /// Additional information about the metafield.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
		
		/// <summary>
        /// The Id of the Shopify Resource that the metafield is associated with. This value could be the id of things like product, order, variant, collection.
        /// </summary>
        [JsonProperty("owner_id")]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The name of the Shopify Resource that the metafield is associated with. This could be things like product, order, variant, collection.
        /// </summary>
        [JsonProperty("owner_resource")]
        public string OwnerResource { get; set; }
    }
}
