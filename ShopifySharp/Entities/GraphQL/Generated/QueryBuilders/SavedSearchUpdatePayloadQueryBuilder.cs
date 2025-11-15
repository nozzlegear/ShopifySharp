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

public class SavedSearchUpdatePayloadQueryBuilder() : GraphQueryBuilder<SavedSearchUpdatePayload>("query savedSearchUpdatePayload")
{
    public SavedSearchUpdatePayloadQueryBuilder AddFieldSavedSearch()
    {
        AddField("savedSearch");
        return this;
    }

    public SavedSearchUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}