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

public class CheckoutBrandingFontSizeQueryBuilder() : GraphQueryBuilder<CheckoutBrandingFontSize>("checkoutBrandingFontSize")
{
    public CheckoutBrandingFontSizeQueryBuilder AddFieldBase()
    {
        AddField("base");
        return this;
    }

    public CheckoutBrandingFontSizeQueryBuilder AddFieldRatio()
    {
        AddField("ratio");
        return this;
    }
}