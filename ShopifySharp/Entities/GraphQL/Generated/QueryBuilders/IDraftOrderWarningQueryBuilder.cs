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

public class IDraftOrderWarningQueryBuilder() : GraphQueryBuilder<IDraftOrderWarning>("query iDraftOrderWarning")
{
    public IDraftOrderWarningQueryBuilder AddFieldErrorCode()
    {
        AddField("errorCode");
        return this;
    }

    public IDraftOrderWarningQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public IDraftOrderWarningQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}