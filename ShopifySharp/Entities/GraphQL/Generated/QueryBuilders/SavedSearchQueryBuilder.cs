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

public class SavedSearchQueryBuilder() : GraphQueryBuilder<SavedSearch>("query savedSearch")
{
    public SavedSearchQueryBuilder AddFieldFilters()
    {
        AddField("filters");
        return this;
    }

    public SavedSearchQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SavedSearchQueryBuilder AddFieldLegacyResourceId()
    {
        AddField("legacyResourceId");
        return this;
    }

    public SavedSearchQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public SavedSearchQueryBuilder AddFieldQuery()
    {
        AddField("query");
        return this;
    }

    public SavedSearchQueryBuilder AddFieldResourceType()
    {
        AddField("resourceType");
        return this;
    }

    public SavedSearchQueryBuilder AddFieldSearchTerms()
    {
        AddField("searchTerms");
        return this;
    }
}