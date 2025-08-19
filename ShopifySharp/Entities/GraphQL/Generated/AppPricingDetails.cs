#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The information about the price that's charged to a shop every plan period.
/// The concrete type can be `AppRecurringPricing` for recurring billing or `AppUsagePricing` for usage-based billing.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(AppRecurringPricing), typeDiscriminator: "AppRecurringPricing")]
[JsonDerivedType(typeof(AppUsagePricing), typeDiscriminator: "AppUsagePricing")]
public record AppPricingDetails : GraphQLObject<AppPricingDetails>, IGraphQLUnionType
{
#if NET6_0_OR_GREATER
	public AppRecurringPricing? AsAppRecurringPricing() => this is AppPricingDetailsAppRecurringPricing wrapper ? wrapper.Value : null;
	public AppUsagePricing? AsAppUsagePricing() => this is AppPricingDetailsAppUsagePricing wrapper ? wrapper.Value : null;
#endif
}