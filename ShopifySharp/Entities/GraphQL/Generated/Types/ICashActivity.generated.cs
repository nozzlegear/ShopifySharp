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
/// An activity on a cash drawer.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CashAdjustmentActivity), typeDiscriminator: "CashAdjustmentActivity")]
[JsonDerivedType(typeof(CashCountActivity), typeDiscriminator: "CashCountActivity")]
[JsonDerivedType(typeof(CashTransactionActivity), typeDiscriminator: "CashTransactionActivity")]
public interface ICashActivity : IGraphQLObject
{
    /// <summary>
    /// The amount of cash added or removed as part of the activity.
    /// </summary>
    [JsonPropertyName("cash")]
    public MoneyV2? cash { get; set; }

    /// <summary>
    /// The point of sale device payment session associated with the activity.
    /// </summary>
    [JsonPropertyName("paymentSession")]
    public PointOfSaleDevicePaymentSession? paymentSession { get; set; }

    /// <summary>
    /// The staff member who performed the activity.
    /// </summary>
    [JsonPropertyName("staffMember")]
    public StaffMember? staffMember { get; set; }

    /// <summary>
    /// The time at which the activity occurred.
    /// </summary>
    [JsonPropertyName("time")]
    public DateTimeOffset? time { get; set; }
}