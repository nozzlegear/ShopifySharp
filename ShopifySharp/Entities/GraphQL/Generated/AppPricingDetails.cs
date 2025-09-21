#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The information about the price that's charged to a shop every plan period.
/// The concrete type can be `AppRecurringPricing` for recurring billing or `AppUsagePricing` for usage-based billing.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<AppPricingDetails>))]
public record AppPricingDetails : GraphQLObject<AppPricingDetails>, IGraphQLUnionType
{
    public AppRecurringPricing? AsAppRecurringPricing() => this is AppPricingDetailsAppRecurringPricing wrapper ? wrapper.Value : null;
    public AppUsagePricing? AsAppUsagePricing() => this is AppPricingDetailsAppUsagePricing wrapper ? wrapper.Value : null;
}