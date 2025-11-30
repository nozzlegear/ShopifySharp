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

public class IProductOperationQueryBuilder() : GraphQueryBuilder<IProductOperation>("query iProductOperation")
{
    public IProductOperationQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public IProductOperationQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}