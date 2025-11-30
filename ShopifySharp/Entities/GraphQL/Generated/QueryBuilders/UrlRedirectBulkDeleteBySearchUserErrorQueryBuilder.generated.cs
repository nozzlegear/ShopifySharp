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

public class UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder() : GraphQueryBuilder<UrlRedirectBulkDeleteBySearchUserError>("urlRedirectBulkDeleteBySearchUserError")
{
    public UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public UrlRedirectBulkDeleteBySearchUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}