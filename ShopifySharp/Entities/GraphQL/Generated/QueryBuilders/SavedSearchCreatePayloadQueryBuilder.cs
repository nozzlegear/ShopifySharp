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

public class SavedSearchCreatePayloadQueryBuilder() : GraphQueryBuilder<SavedSearchCreatePayload>("query savedSearchCreatePayload")
{
    public SavedSearchCreatePayloadQueryBuilder AddFieldSavedSearch()
    {
        AddField("savedSearch");
        return this;
    }

    public SavedSearchCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}