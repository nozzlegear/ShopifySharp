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

public class AppPurchaseOneTimeCreateQueryBuilder() : GraphQueryBuilder<AppPurchaseOneTimeCreatePayload>("query appPurchaseOneTimeCreate")
{
    public AppPurchaseOneTimeCreateQueryBuilder AddArgumentName(string? name)
    {
        AddArgument("name", name);
        return this;
    }

    public AppPurchaseOneTimeCreateQueryBuilder AddArgumentPrice(MoneyInput? price)
    {
        AddArgument("price", price);
        return this;
    }

    public AppPurchaseOneTimeCreateQueryBuilder AddArgumentReturnUrl(string? returnUrl)
    {
        AddArgument("returnUrl", returnUrl);
        return this;
    }

    public AppPurchaseOneTimeCreateQueryBuilder AddArgumentTest(bool? test)
    {
        AddArgument("test", test);
        return this;
    }
}