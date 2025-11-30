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

public class DraftOrderBundleAddedWarningQueryBuilder() : GraphQueryBuilder<DraftOrderBundleAddedWarning>("query draftOrderBundleAddedWarning")
{
    public DraftOrderBundleAddedWarningQueryBuilder AddFieldErrorCode()
    {
        AddField("errorCode");
        return this;
    }

    public DraftOrderBundleAddedWarningQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public DraftOrderBundleAddedWarningQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}