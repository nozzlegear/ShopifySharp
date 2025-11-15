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

public class CheckoutBrandingDividerStyleQueryBuilder() : GraphQueryBuilder<CheckoutBrandingDividerStyle>("query checkoutBrandingDividerStyle")
{
    public CheckoutBrandingDividerStyleQueryBuilder AddFieldBorderStyle()
    {
        AddField("borderStyle");
        return this;
    }

    public CheckoutBrandingDividerStyleQueryBuilder AddFieldBorderWidth()
    {
        AddField("borderWidth");
        return this;
    }
}