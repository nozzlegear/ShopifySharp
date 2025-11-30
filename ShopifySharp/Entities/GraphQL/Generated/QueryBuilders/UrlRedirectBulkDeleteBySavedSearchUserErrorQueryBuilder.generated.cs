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

public class UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder() : GraphQueryBuilder<UrlRedirectBulkDeleteBySavedSearchUserError>("urlRedirectBulkDeleteBySavedSearchUserError")
{
    public UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public UrlRedirectBulkDeleteBySavedSearchUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}