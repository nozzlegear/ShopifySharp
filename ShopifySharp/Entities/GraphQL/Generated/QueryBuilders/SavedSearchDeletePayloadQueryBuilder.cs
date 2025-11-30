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

public class SavedSearchDeletePayloadQueryBuilder() : GraphQueryBuilder<SavedSearchDeletePayload>("query savedSearchDeletePayload")
{
    public SavedSearchDeletePayloadQueryBuilder AddFieldDeletedSavedSearchId()
    {
        AddField("deletedSavedSearchId");
        return this;
    }

    public SavedSearchDeletePayloadQueryBuilder AddFieldShop()
    {
        AddField("shop");
        return this;
    }

    public SavedSearchDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}