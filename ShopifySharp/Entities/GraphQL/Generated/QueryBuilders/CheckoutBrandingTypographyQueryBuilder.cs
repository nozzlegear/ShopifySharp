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

public class CheckoutBrandingTypographyQueryBuilder() : GraphQueryBuilder<CheckoutBrandingTypography>("query checkoutBrandingTypography")
{
    public CheckoutBrandingTypographyQueryBuilder AddFieldPrimary()
    {
        AddField("primary");
        return this;
    }

    public CheckoutBrandingTypographyQueryBuilder AddFieldSecondary()
    {
        AddField("secondary");
        return this;
    }

    public CheckoutBrandingTypographyQueryBuilder AddFieldSize()
    {
        AddField("size");
        return this;
    }
}