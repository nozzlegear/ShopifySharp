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

public class CustomerVisitProductInfoQueryBuilder() : GraphQueryBuilder<CustomerVisitProductInfo>("query customerVisitProductInfo")
{
    public CustomerVisitProductInfoQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public CustomerVisitProductInfoQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public CustomerVisitProductInfoQueryBuilder AddFieldVariant()
    {
        AddField("variant");
        return this;
    }
}