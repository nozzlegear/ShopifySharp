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

public class ReverseFulfillmentOrderDisposeQueryBuilder() : GraphQueryBuilder<ReverseFulfillmentOrderDisposePayload>("query reverseFulfillmentOrderDispose")
{
    public ReverseFulfillmentOrderDisposeQueryBuilder AddArgumentDispositionInputs(ICollection<ReverseFulfillmentOrderDisposeInput>? dispositionInputs)
    {
        AddArgument("dispositionInputs", dispositionInputs);
        return this;
    }
}