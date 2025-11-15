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

public class CartTransformEligibleOperationsQueryBuilder() : GraphQueryBuilder<CartTransformEligibleOperations>("query cartTransformEligibleOperations")
{
    public CartTransformEligibleOperationsQueryBuilder AddFieldExpandOperation()
    {
        AddField("expandOperation");
        return this;
    }

    public CartTransformEligibleOperationsQueryBuilder AddFieldMergeOperation()
    {
        AddField("mergeOperation");
        return this;
    }

    public CartTransformEligibleOperationsQueryBuilder AddFieldUpdateOperation()
    {
        AddField("updateOperation");
        return this;
    }
}