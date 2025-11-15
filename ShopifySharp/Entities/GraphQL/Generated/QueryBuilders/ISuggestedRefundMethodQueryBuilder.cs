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

public class ISuggestedRefundMethodQueryBuilder() : GraphQueryBuilder<ISuggestedRefundMethod>("query iSuggestedRefundMethod")
{
    public ISuggestedRefundMethodQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public ISuggestedRefundMethodQueryBuilder AddFieldMaximumRefundable()
    {
        AddField("maximumRefundable");
        return this;
    }
}