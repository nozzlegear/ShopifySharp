#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the body of a theme file.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(OnlineStoreThemeFileBodyOnlineStoreThemeFileBodyBase64), typeDiscriminator: "OnlineStoreThemeFileBodyBase64")]
[JsonDerivedType(typeof(OnlineStoreThemeFileBodyOnlineStoreThemeFileBodyText), typeDiscriminator: "OnlineStoreThemeFileBodyText")]
[JsonDerivedType(typeof(OnlineStoreThemeFileBodyOnlineStoreThemeFileBodyUrl), typeDiscriminator: "OnlineStoreThemeFileBodyUrl")]
public record OnlineStoreThemeFileBody : GraphQLObject<OnlineStoreThemeFileBody>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public OnlineStoreThemeFileBodyBase64? AsOnlineStoreThemeFileBodyBase64() => this is OnlineStoreThemeFileBodyOnlineStoreThemeFileBodyBase64 wrapper ? wrapper.Value : null;
	public OnlineStoreThemeFileBodyText? AsOnlineStoreThemeFileBodyText() => this is OnlineStoreThemeFileBodyOnlineStoreThemeFileBodyText wrapper ? wrapper.Value : null;
	public OnlineStoreThemeFileBodyUrl? AsOnlineStoreThemeFileBodyUrl() => this is OnlineStoreThemeFileBodyOnlineStoreThemeFileBodyUrl wrapper ? wrapper.Value : null;
#endif
}