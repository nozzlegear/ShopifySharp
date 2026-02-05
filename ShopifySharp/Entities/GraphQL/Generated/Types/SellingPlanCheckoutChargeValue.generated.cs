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
/// The portion of the price to be charged at checkout.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<SellingPlanCheckoutChargeValue>))]
public record SellingPlanCheckoutChargeValue : GraphQLObject<SellingPlanCheckoutChargeValue>, IGraphQLUnionType
{
    public MoneyV2? AsMoneyV2() => this is SellingPlanCheckoutChargeValueMoneyV2 wrapper ? wrapper.Value : null;
    public SellingPlanCheckoutChargePercentageValue? AsSellingPlanCheckoutChargePercentageValue() => this is SellingPlanCheckoutChargeValueSellingPlanCheckoutChargePercentageValue wrapper ? wrapper.Value : null;
}