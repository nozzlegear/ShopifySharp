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

public class CheckoutBrandingColorSchemesQueryBuilder() : GraphQueryBuilder<CheckoutBrandingColorSchemes>("query checkoutBrandingColorSchemes")
{
    public CheckoutBrandingColorSchemesQueryBuilder AddFieldScheme1()
    {
        AddField("scheme1");
        return this;
    }

    public CheckoutBrandingColorSchemesQueryBuilder AddFieldScheme2()
    {
        AddField("scheme2");
        return this;
    }

    public CheckoutBrandingColorSchemesQueryBuilder AddFieldScheme3()
    {
        AddField("scheme3");
        return this;
    }

    public CheckoutBrandingColorSchemesQueryBuilder AddFieldScheme4()
    {
        AddField("scheme4");
        return this;
    }
}