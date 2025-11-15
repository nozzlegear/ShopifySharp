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

public class CombinedListingQueryBuilder() : GraphQueryBuilder<CombinedListing>("query combinedListing")
{
    public CombinedListingQueryBuilder AddFieldCombinedListingChildren()
    {
        AddField("combinedListingChildren");
        return this;
    }

    public CombinedListingQueryBuilder AddFieldParentProduct()
    {
        AddField("parentProduct");
        return this;
    }
}