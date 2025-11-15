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

public class CheckoutBrandingLogoQueryBuilder() : GraphQueryBuilder<CheckoutBrandingLogo>("query checkoutBrandingLogo")
{
    public CheckoutBrandingLogoQueryBuilder AddFieldImage()
    {
        AddField("image");
        return this;
    }

    public CheckoutBrandingLogoQueryBuilder AddFieldMaxWidth()
    {
        AddField("maxWidth");
        return this;
    }

    public CheckoutBrandingLogoQueryBuilder AddFieldVisibility()
    {
        AddField("visibility");
        return this;
    }
}