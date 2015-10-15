using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// An enum representing the type of <see cref="ShopifyScriptTag.Event"/>.
    /// </summary>
    public enum ShopifyScriptTagEvent
    {
        /// <summary>
        /// The script tag is triggered when the DOM fires the "Onload" event.
        /// </summary>
        [EnumMember(Value = "onload")]
        Onload
    }
}
