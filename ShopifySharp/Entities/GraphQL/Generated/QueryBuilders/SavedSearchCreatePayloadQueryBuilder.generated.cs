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

public class SavedSearchCreatePayloadQueryBuilder() : GraphQueryBuilder<SavedSearchCreatePayload>("savedSearchCreatePayload")
{
    public SavedSearchCreatePayloadQueryBuilder AddFieldSavedSearch(Func<SavedSearchQueryBuilder, SavedSearchQueryBuilder> build)
    {
        AddField<SavedSearch, SavedSearchQueryBuilder>("savedSearch", build);
        return this;
    }

    public SavedSearchCreatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}