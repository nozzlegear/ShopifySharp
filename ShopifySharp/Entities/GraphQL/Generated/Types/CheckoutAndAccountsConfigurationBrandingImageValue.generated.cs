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
/// The image value.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<CheckoutAndAccountsConfigurationBrandingImageValue>))]
public record CheckoutAndAccountsConfigurationBrandingImageValue : GraphQLObject<CheckoutAndAccountsConfigurationBrandingImageValue>, IGraphQLUnionType
{
    public CheckoutAndAccountsConfigurationBrandingImage? AsCheckoutAndAccountsConfigurationBrandingImage() => this is CheckoutAndAccountsConfigurationBrandingImageValueCheckoutAndAccountsConfigurationBrandingImage wrapper ? wrapper.Value : null;
}