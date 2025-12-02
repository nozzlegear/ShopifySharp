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

public class PageDeletePayloadQueryBuilder() : GraphQueryBuilder<PageDeletePayload>("pageDeletePayload")
{
    public PageDeletePayloadQueryBuilder AddFieldDeletedPageId()
    {
        AddField("deletedPageId");
        return this;
    }

    public PageDeletePayloadQueryBuilder AddFieldUserErrors(Func<PageDeleteUserErrorQueryBuilder, PageDeleteUserErrorQueryBuilder> build)
    {
        AddField<PageDeleteUserError, PageDeleteUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}