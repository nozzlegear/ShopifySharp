#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Configuration of the deposit.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<DepositConfiguration>))]
public record DepositConfiguration : GraphQLObject<DepositConfiguration>, IGraphQLUnionType
{
    public DepositPercentage? AsDepositPercentage() => this is DepositConfigurationDepositPercentage wrapper ? wrapper.Value : null;
}