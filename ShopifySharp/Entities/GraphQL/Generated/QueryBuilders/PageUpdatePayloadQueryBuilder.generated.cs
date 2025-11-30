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

public class PageUpdatePayloadQueryBuilder() : GraphQueryBuilder<PageUpdatePayload>("pageUpdatePayload")
{
    public PageUpdatePayloadQueryBuilder AddFieldPage(Func<PageQueryBuilder, PageQueryBuilder> build)
    {
        AddField<Page, PageQueryBuilder>("page", build);
        return this;
    }

    public PageUpdatePayloadQueryBuilder AddFieldUserErrors(Func<PageUpdateUserErrorQueryBuilder, PageUpdateUserErrorQueryBuilder> build)
    {
        AddField<PageUpdateUserError, PageUpdateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}