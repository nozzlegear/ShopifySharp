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
/// Represents the body of a theme file.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<OnlineStoreThemeFileBody>))]
public record OnlineStoreThemeFileBody : GraphQLObject<OnlineStoreThemeFileBody>, IGraphQLUnionType
{
    public OnlineStoreThemeFileBodyBase64? AsOnlineStoreThemeFileBodyBase64() => this is OnlineStoreThemeFileBodyOnlineStoreThemeFileBodyBase64 wrapper ? wrapper.Value : null;
    public OnlineStoreThemeFileBodyText? AsOnlineStoreThemeFileBodyText() => this is OnlineStoreThemeFileBodyOnlineStoreThemeFileBodyText wrapper ? wrapper.Value : null;
    public OnlineStoreThemeFileBodyUrl? AsOnlineStoreThemeFileBodyUrl() => this is OnlineStoreThemeFileBodyOnlineStoreThemeFileBodyUrl wrapper ? wrapper.Value : null;
}