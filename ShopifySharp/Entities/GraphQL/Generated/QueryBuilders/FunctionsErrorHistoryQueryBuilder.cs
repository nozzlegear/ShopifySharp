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

public class FunctionsErrorHistoryQueryBuilder() : GraphQueryBuilder<FunctionsErrorHistory>("query functionsErrorHistory")
{
    public FunctionsErrorHistoryQueryBuilder AddFieldErrorsFirstOccurredAt()
    {
        AddField("errorsFirstOccurredAt");
        return this;
    }

    public FunctionsErrorHistoryQueryBuilder AddFieldFirstOccurredAt()
    {
        AddField("firstOccurredAt");
        return this;
    }

    public FunctionsErrorHistoryQueryBuilder AddFieldHasBeenSharedSinceLastError()
    {
        AddField("hasBeenSharedSinceLastError");
        return this;
    }

    public FunctionsErrorHistoryQueryBuilder AddFieldHasSharedRecentErrors()
    {
        AddField("hasSharedRecentErrors");
        return this;
    }
}