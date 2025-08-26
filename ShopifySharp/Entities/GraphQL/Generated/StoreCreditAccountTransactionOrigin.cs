#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The origin of a store credit account transaction.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(StoreCreditAccountTransactionOriginOrderTransaction), typeDiscriminator: "OrderTransaction")]
public record StoreCreditAccountTransactionOrigin : GraphQLObject<StoreCreditAccountTransactionOrigin>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public OrderTransaction? AsOrderTransaction() => this is StoreCreditAccountTransactionOriginOrderTransaction wrapper ? wrapper.Value : null;
#endif
}