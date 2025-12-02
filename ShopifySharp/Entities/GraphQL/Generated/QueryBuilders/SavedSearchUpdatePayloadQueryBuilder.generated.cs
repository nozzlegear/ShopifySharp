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

public class SavedSearchUpdatePayloadQueryBuilder() : GraphQueryBuilder<SavedSearchUpdatePayload>("savedSearchUpdatePayload")
{
    public SavedSearchUpdatePayloadQueryBuilder AddFieldSavedSearch(Func<SavedSearchQueryBuilder, SavedSearchQueryBuilder> build)
    {
        AddField<SavedSearch, SavedSearchQueryBuilder>("savedSearch", build);
        return this;
    }

    public SavedSearchUpdatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}