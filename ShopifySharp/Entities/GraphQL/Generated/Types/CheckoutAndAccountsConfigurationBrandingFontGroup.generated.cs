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
/// A group of fonts.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<CheckoutAndAccountsConfigurationBrandingFontGroup>))]
public record CheckoutAndAccountsConfigurationBrandingFontGroup : GraphQLObject<CheckoutAndAccountsConfigurationBrandingFontGroup>, IGraphQLUnionType
{
    public CheckoutAndAccountsConfigurationBrandingCustomFontGroup? AsCheckoutAndAccountsConfigurationBrandingCustomFontGroup() => this is CheckoutAndAccountsConfigurationBrandingFontGroupCheckoutAndAccountsConfigurationBrandingCustomFontGroup wrapper ? wrapper.Value : null;
    public CheckoutAndAccountsConfigurationBrandingShopifyFontGroup? AsCheckoutAndAccountsConfigurationBrandingShopifyFontGroup() => this is CheckoutAndAccountsConfigurationBrandingFontGroupCheckoutAndAccountsConfigurationBrandingShopifyFontGroup wrapper ? wrapper.Value : null;
}