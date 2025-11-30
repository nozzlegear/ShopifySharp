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

public class UrlRedirectBulkDeleteByIdsUserErrorQueryBuilder() : GraphQueryBuilder<UrlRedirectBulkDeleteByIdsUserError>("urlRedirectBulkDeleteByIdsUserError")
{
    public UrlRedirectBulkDeleteByIdsUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public UrlRedirectBulkDeleteByIdsUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public UrlRedirectBulkDeleteByIdsUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}