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

public class FulfillmentServiceDeleteQueryBuilder() : GraphQueryBuilder<FulfillmentServiceDeletePayload>("fulfillmentServiceDelete"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public FulfillmentServiceDeleteQueryBuilder AddArgumentDestinationLocationId(string? destinationLocationId)
    {
        AddArgument("destinationLocationId", destinationLocationId);
        return this;
    }

    public FulfillmentServiceDeleteQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public FulfillmentServiceDeleteQueryBuilder AddArgumentInventoryAction(FulfillmentServiceDeleteInventoryAction? inventoryAction)
    {
        AddArgument("inventoryAction", inventoryAction);
        return this;
    }
}