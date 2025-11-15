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

public class CheckoutBrandingDesignSystemQueryBuilder() : GraphQueryBuilder<CheckoutBrandingDesignSystem>("query checkoutBrandingDesignSystem")
{
    public CheckoutBrandingDesignSystemQueryBuilder AddFieldColors()
    {
        AddField("colors");
        return this;
    }

    public CheckoutBrandingDesignSystemQueryBuilder AddFieldCornerRadius()
    {
        AddField("cornerRadius");
        return this;
    }

    public CheckoutBrandingDesignSystemQueryBuilder AddFieldTypography()
    {
        AddField("typography");
        return this;
    }
}