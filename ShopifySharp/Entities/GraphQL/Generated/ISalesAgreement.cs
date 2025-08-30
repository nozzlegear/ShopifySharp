#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A contract between a merchant and a customer to do business. Shopify creates a
/// sales agreement whenever an order is placed, edited, or refunded. A sales
/// agreement has one or more sales records, which provide itemized details about
/// the initial agreement or subsequent changes made to the order. For example, when
/// a customer places an order, Shopify creates the order, generates a sales
/// agreement, and records a sale for each line item purchased in the order. A sale
/// record is specific to a type of order line. Order lines can represent different
/// things such as a purchased product, a tip added by a customer, shipping costs
/// collected at checkout, and more.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(OrderAgreement), typeDiscriminator: "OrderAgreement")]
[JsonDerivedType(typeof(OrderEditAgreement), typeDiscriminator: "OrderEditAgreement")]
[JsonDerivedType(typeof(RefundAgreement), typeDiscriminator: "RefundAgreement")]
[JsonDerivedType(typeof(ReturnAgreement), typeDiscriminator: "ReturnAgreement")]
public interface ISalesAgreement : IGraphQLObject
{
    /// <summary>
    /// The application that created the agreement.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; }

    /// <summary>
    /// The date and time at which the agreement occured.
    /// </summary>
    [JsonPropertyName("happenedAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? happenedAt { get; set; }

    /// <summary>
    /// The unique ID for the agreement.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }

    /// <summary>
    /// The reason the agremeent was created.
    /// </summary>
    [JsonPropertyName("reason")]
    public OrderActionType? reason { get; set; }

    /// <summary>
    /// The sales associated with the agreement.
    /// </summary>
    [JsonPropertyName("sales")]
    public SaleConnection? sales { get; set; }

    /// <summary>
    /// The staff member associated with the agreement.
    /// </summary>
    [JsonPropertyName("user")]
    public StaffMember? user { get; set; }
}