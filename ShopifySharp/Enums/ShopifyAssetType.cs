using Newtonsoft.Json;
using ShopifySharp.Converters;
using System.Runtime.Serialization;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// An enum representing the type or "bucket" of a <see cref="ShopifyAsset"/>.
    /// </summary>
    /// <remarks>This enum is never serialized or deserialized.</remarks>
    [JsonConverter(typeof(NullableEnumConverter<ShopifyAssetType>))]
    public enum ShopifyAssetType
    {
        /// <summary>
        /// The asset is part of the layout bucket.
        /// </summary>
        [EnumMember(Value ="layout")]
        Layout,

        /// <summary>
        /// The asset is part of the templates bucket.
        /// </summary>
        [EnumMember(Value = "templates")]
        Templates,

        /// <summary>
        /// The asset is part of the assets bucket.
        /// </summary>
        [EnumMember(Value = "assets")]
        Assets
    }
}
