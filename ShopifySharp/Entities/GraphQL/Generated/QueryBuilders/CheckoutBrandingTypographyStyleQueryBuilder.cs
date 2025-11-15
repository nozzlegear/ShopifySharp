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

public class CheckoutBrandingTypographyStyleQueryBuilder() : GraphQueryBuilder<CheckoutBrandingTypographyStyle>("query checkoutBrandingTypographyStyle")
{
    public CheckoutBrandingTypographyStyleQueryBuilder AddFieldFont()
    {
        AddField("font");
        return this;
    }

    public CheckoutBrandingTypographyStyleQueryBuilder AddFieldKerning()
    {
        AddField("kerning");
        return this;
    }

    public CheckoutBrandingTypographyStyleQueryBuilder AddFieldLetterCase()
    {
        AddField("letterCase");
        return this;
    }

    public CheckoutBrandingTypographyStyleQueryBuilder AddFieldSize()
    {
        AddField("size");
        return this;
    }

    public CheckoutBrandingTypographyStyleQueryBuilder AddFieldWeight()
    {
        AddField("weight");
        return this;
    }
}