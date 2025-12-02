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

public class CombinedListingUpdateQueryBuilder() : GraphQueryBuilder<CombinedListingUpdatePayload>("combinedListingUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CombinedListingUpdateQueryBuilder AddArgumentOptionsAndValues(ICollection<OptionAndValueInput>? optionsAndValues)
    {
        AddArgument("optionsAndValues", optionsAndValues);
        return this;
    }

    public CombinedListingUpdateQueryBuilder AddArgumentParentProductId(string? parentProductId)
    {
        AddArgument("parentProductId", parentProductId);
        return this;
    }

    public CombinedListingUpdateQueryBuilder AddArgumentProductsAdded(ICollection<ChildProductRelationInput>? productsAdded)
    {
        AddArgument("productsAdded", productsAdded);
        return this;
    }

    public CombinedListingUpdateQueryBuilder AddArgumentProductsEdited(ICollection<ChildProductRelationInput>? productsEdited)
    {
        AddArgument("productsEdited", productsEdited);
        return this;
    }

    public CombinedListingUpdateQueryBuilder AddArgumentProductsRemovedIds(ICollection<string>? productsRemovedIds)
    {
        AddArgument("productsRemovedIds", productsRemovedIds);
        return this;
    }

    public CombinedListingUpdateQueryBuilder AddArgumentTitle(string? title)
    {
        AddArgument("title", title);
        return this;
    }
}