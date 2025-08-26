#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The main embed of a comment event.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CommentEventEmbedCustomer), typeDiscriminator: "Customer")]
[JsonDerivedType(typeof(CommentEventEmbedDraftOrder), typeDiscriminator: "DraftOrder")]
[JsonDerivedType(typeof(CommentEventEmbedInventoryTransfer), typeDiscriminator: "InventoryTransfer")]
[JsonDerivedType(typeof(CommentEventEmbedOrder), typeDiscriminator: "Order")]
[JsonDerivedType(typeof(CommentEventEmbedProduct), typeDiscriminator: "Product")]
[JsonDerivedType(typeof(CommentEventEmbedProductVariant), typeDiscriminator: "ProductVariant")]
public record CommentEventEmbed : GraphQLObject<CommentEventEmbed>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public Customer? AsCustomer() => this is CommentEventEmbedCustomer wrapper ? wrapper.Value : null;
	public DraftOrder? AsDraftOrder() => this is CommentEventEmbedDraftOrder wrapper ? wrapper.Value : null;
	public InventoryTransfer? AsInventoryTransfer() => this is CommentEventEmbedInventoryTransfer wrapper ? wrapper.Value : null;
	public Order? AsOrder() => this is CommentEventEmbedOrder wrapper ? wrapper.Value : null;
	public Product? AsProduct() => this is CommentEventEmbedProduct wrapper ? wrapper.Value : null;
	public ProductVariant? AsProductVariant() => this is CommentEventEmbedProductVariant wrapper ? wrapper.Value : null;
#endif
}