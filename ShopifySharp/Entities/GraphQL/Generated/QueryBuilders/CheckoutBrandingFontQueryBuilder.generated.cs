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

public class CheckoutBrandingFontQueryBuilder() : GraphQueryBuilder<ICheckoutBrandingFont>("checkoutBrandingFont")
{
    public CheckoutBrandingFontQueryBuilder AddFieldSources()
    {
        AddField("sources");
        return this;
    }

    public CheckoutBrandingFontQueryBuilder AddFieldWeight()
    {
        AddField("weight");
        return this;
    }
}