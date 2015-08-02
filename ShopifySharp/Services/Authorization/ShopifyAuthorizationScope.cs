using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public enum ShopifyAuthorizationScope
    {
        [Description("read_content")]
        ReadContent,

        [Description("write_content")]
        WriteContent,

        [Description("read_themes")]
        ReadThemes,

        [Description("write_themes")]
        WriteThemes,

        [Description("read_products")]
        ReadProducts,

        [Description("write_products")]
        WriteProducts,

        [Description("read_customers")]
        ReadCustomers,

        [Description("write_customers")]
        WriteCustomers,

        [Description("read_orders")]
        ReadOrders,

        [Description("write_orders")]
        WriteOrders,

        [Description("read_script_tags")]
        ReadScriptTags,

        [Description("write_script_tags")]
        WriteScriptTags,

        [Description("read_fulfillments")]
        ReadFulfillments,

        [Description("write_fulfillments")]
        WriteFulfillments,

        [Description("read_shipping")]
        ReadShipping,

        [Description("write_shipping")]
        WriteShipping
    }
}
