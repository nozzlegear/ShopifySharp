#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents information about the purchasing entity for the order or draft order.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(PurchasingEntityCustomer), typeDiscriminator: "Customer")]
[JsonDerivedType(typeof(PurchasingEntityPurchasingCompany), typeDiscriminator: "PurchasingCompany")]
public record PurchasingEntity : GraphQLObject<PurchasingEntity>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public Customer? AsCustomer() => this is PurchasingEntityCustomer wrapper ? wrapper.Value : null;
	public PurchasingCompany? AsPurchasingCompany() => this is PurchasingEntityPurchasingCompany wrapper ? wrapper.Value : null;
#endif
}