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

public class DeliveryBrandedPromiseQueryBuilder() : GraphQueryBuilder<DeliveryBrandedPromise>("deliveryBrandedPromise")
{
    public DeliveryBrandedPromiseQueryBuilder AddFieldHandle()
    {
        AddField("handle");
        return this;
    }

    public DeliveryBrandedPromiseQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }
}