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

public class ReverseFulfillmentOrderDisposeQueryBuilder() : GraphQueryBuilder<ReverseFulfillmentOrderDisposePayload>("reverseFulfillmentOrderDispose"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ReverseFulfillmentOrderDisposeQueryBuilder AddArgumentDispositionInputs(ICollection<ReverseFulfillmentOrderDisposeInput>? dispositionInputs)
    {
        AddArgument("dispositionInputs", dispositionInputs);
        return this;
    }
}