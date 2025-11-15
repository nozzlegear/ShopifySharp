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

public class CheckoutBrandingFontGroupQueryBuilder() : GraphQueryBuilder<CheckoutBrandingFontGroup>("query checkoutBrandingFontGroup")
{
    public CheckoutBrandingFontGroupQueryBuilder AddFieldBase()
    {
        AddField("base");
        return this;
    }

    public CheckoutBrandingFontGroupQueryBuilder AddFieldBold()
    {
        AddField("bold");
        return this;
    }

    public CheckoutBrandingFontGroupQueryBuilder AddFieldLoadingStrategy()
    {
        AddField("loadingStrategy");
        return this;
    }

    public CheckoutBrandingFontGroupQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }
}