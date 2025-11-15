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

public class CombinedListingChildQueryBuilder() : GraphQueryBuilder<CombinedListingChild>("query combinedListingChild")
{
    public CombinedListingChildQueryBuilder AddFieldParentVariant()
    {
        AddField("parentVariant");
        return this;
    }

    public CombinedListingChildQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }
}