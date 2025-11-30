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

public class CheckoutBrandingColorsQueryBuilder() : GraphQueryBuilder<CheckoutBrandingColors>("query checkoutBrandingColors")
{
    public CheckoutBrandingColorsQueryBuilder AddFieldGlobal()
    {
        AddField("global");
        return this;
    }

    public CheckoutBrandingColorsQueryBuilder AddFieldSchemes()
    {
        AddField("schemes");
        return this;
    }
}