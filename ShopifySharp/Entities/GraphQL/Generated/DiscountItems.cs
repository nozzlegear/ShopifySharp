#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type used to target the items required for discount eligibility, or the
/// items to which the application of a discount might apply. For example, for a
/// customer to be eligible for a discount, they're required to add an item from a
/// specified collection to their order. Alternatively, a customer might be required
/// to add a specific product or product variant. When using this type to target
/// which items the discount will apply to, the discount might apply to all items on
/// the order, or to specific products and product variants, or items in a given collection.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(AllDiscountItems), typeDiscriminator: "AllDiscountItems")]
[JsonDerivedType(typeof(DiscountCollections), typeDiscriminator: "DiscountCollections")]
[JsonDerivedType(typeof(DiscountProducts), typeDiscriminator: "DiscountProducts")]
public record DiscountItems : GraphQLObject<DiscountItems>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public AllDiscountItems? AsAllDiscountItems() => this is DiscountItemsAllDiscountItems wrapper ? wrapper.Value : null;
	public DiscountCollections? AsDiscountCollections() => this is DiscountItemsDiscountCollections wrapper ? wrapper.Value : null;
	public DiscountProducts? AsDiscountProducts() => this is DiscountItemsDiscountProducts wrapper ? wrapper.Value : null;
#endif
}