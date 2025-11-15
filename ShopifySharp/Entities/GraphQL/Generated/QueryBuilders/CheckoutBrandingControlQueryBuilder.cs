#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CheckoutBrandingControlQueryBuilder() : GraphQueryBuilder<CheckoutBrandingControl>("query checkoutBrandingControl")
{
    public CheckoutBrandingControlQueryBuilder AddFieldBorder()
    {
        AddField("border");
        return this;
    }

    public CheckoutBrandingControlQueryBuilder AddFieldColor()
    {
        AddField("color");
        return this;
    }

    public CheckoutBrandingControlQueryBuilder AddFieldCornerRadius()
    {
        AddField("cornerRadius");
        return this;
    }

    public CheckoutBrandingControlQueryBuilder AddFieldLabelPosition()
    {
        AddField("labelPosition");
        return this;
    }
}