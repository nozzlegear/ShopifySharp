#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents information about the purchasing entity for the order or draft order.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<PurchasingEntity>))]
public record PurchasingEntity : GraphQLObject<PurchasingEntity>, IGraphQLUnionType
{
    public Customer? AsCustomer() => this is PurchasingEntityCustomer wrapper ? wrapper.Value : null;
    public PurchasingCompany? AsPurchasingCompany() => this is PurchasingEntityPurchasingCompany wrapper ? wrapper.Value : null;
}