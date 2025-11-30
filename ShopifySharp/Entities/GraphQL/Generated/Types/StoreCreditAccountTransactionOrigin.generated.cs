#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The origin of a store credit account transaction.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<StoreCreditAccountTransactionOrigin>))]
public record StoreCreditAccountTransactionOrigin : GraphQLObject<StoreCreditAccountTransactionOrigin>, IGraphQLUnionType
{
    public OrderTransaction? AsOrderTransaction() => this is StoreCreditAccountTransactionOriginOrderTransaction wrapper ? wrapper.Value : null;
}