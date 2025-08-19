#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

#if NET6_0_OR_GREATER
internal record DiscountCustomerSelectionDiscountCustomerAll(DiscountCustomerAll Value): DiscountCustomerSelection;
internal record DiscountCustomerSelectionDiscountCustomerSegments(DiscountCustomerSegments Value): DiscountCustomerSelection;
internal record DiscountCustomerSelectionDiscountCustomers(DiscountCustomers Value): DiscountCustomerSelection;
#endif /// <summary>

/// The input fields for the customers who can use this discount.
/// </summary>
public record DiscountCustomerSelectionInput : GraphQLInputObject<DiscountCustomerSelectionInput>
{
    /// <summary>
    /// Whether all customers can use this discount.
    /// </summary>
    [JsonPropertyName("all")]
    public bool? all { get; set; } = null;

    /// <summary>
    /// The list of customer IDs to add or remove from the list of customers.
    /// </summary>
    [JsonPropertyName("customers")]
    public DiscountCustomersInput? customers { get; set; } = null;

    /// <summary>
    /// The list of customer segment IDs to add or remove from the list of customer segments.
    /// </summary>
    [JsonPropertyName("customerSegments")]
    public DiscountCustomerSegmentsInput? customerSegments { get; set; } = null;
}