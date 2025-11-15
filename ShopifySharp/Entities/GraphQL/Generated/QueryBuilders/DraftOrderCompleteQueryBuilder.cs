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

public class DraftOrderCompleteQueryBuilder() : GraphQueryBuilder<DraftOrderCompletePayload>("query draftOrderComplete")
{
    public DraftOrderCompleteQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public DraftOrderCompleteQueryBuilder AddArgumentPaymentGatewayId(string? paymentGatewayId)
    {
        AddArgument("paymentGatewayId", paymentGatewayId);
        return this;
    }

    public DraftOrderCompleteQueryBuilder AddArgumentSourceName(string? sourceName)
    {
        AddArgument("sourceName", sourceName);
        return this;
    }
}