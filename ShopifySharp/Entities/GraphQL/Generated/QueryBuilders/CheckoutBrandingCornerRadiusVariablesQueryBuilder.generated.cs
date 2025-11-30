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

public class CheckoutBrandingCornerRadiusVariablesQueryBuilder() : GraphQueryBuilder<CheckoutBrandingCornerRadiusVariables>("checkoutBrandingCornerRadiusVariables")
{
    public CheckoutBrandingCornerRadiusVariablesQueryBuilder AddFieldBase()
    {
        AddField("base");
        return this;
    }

    public CheckoutBrandingCornerRadiusVariablesQueryBuilder AddFieldLarge()
    {
        AddField("large");
        return this;
    }

    public CheckoutBrandingCornerRadiusVariablesQueryBuilder AddFieldSmall()
    {
        AddField("small");
        return this;
    }
}