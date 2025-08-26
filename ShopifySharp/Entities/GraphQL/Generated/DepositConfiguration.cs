#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Configuration of the deposit.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(DepositConfigurationDepositPercentage), typeDiscriminator: "DepositPercentage")]
public record DepositConfiguration : GraphQLObject<DepositConfiguration>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public DepositPercentage? AsDepositPercentage() => this is DepositConfigurationDepositPercentage wrapper ? wrapper.Value : null;
#endif
}