#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CheckoutBrandingShopifyFontQueryBuilder() : GraphQueryBuilder<CheckoutBrandingShopifyFont>("checkoutBrandingShopifyFont")
{
    public CheckoutBrandingShopifyFontQueryBuilder AddFieldSources()
    {
        AddField("sources");
        return this;
    }

    public CheckoutBrandingShopifyFontQueryBuilder AddFieldWeight()
    {
        AddField("weight");
        return this;
    }
}