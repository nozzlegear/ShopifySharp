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

public class PageCreatePayloadQueryBuilder() : GraphQueryBuilder<PageCreatePayload>("pageCreatePayload")
{
    public PageCreatePayloadQueryBuilder AddFieldPage(Func<PageQueryBuilder, PageQueryBuilder> build)
    {
        AddField<Page, PageQueryBuilder>("page", build);
        return this;
    }

    public PageCreatePayloadQueryBuilder AddFieldUserErrors(Func<PageCreateUserErrorQueryBuilder, PageCreateUserErrorQueryBuilder> build)
    {
        AddField<PageCreateUserError, PageCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}