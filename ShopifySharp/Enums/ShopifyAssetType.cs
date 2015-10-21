using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// An enum representing the type or "bucket" of a <see cref="ShopifyAsset"/>.
    /// </summary>
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
