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
/// The type used for targeting a set of customers who are eligible for the
/// discount. For example, the discount might be available to all customers or it
/// might only be available to a specific set of customers. You can define the set
/// of customers by targeting a list of customer segments, or by targeting a list of
/// specific customers.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<DiscountCustomerSelection>))]
public record DiscountCustomerSelection : GraphQLObject<DiscountCustomerSelection>, IGraphQLUnionType
{
    public DiscountCustomerAll? AsDiscountCustomerAll() => this is DiscountCustomerSelectionDiscountCustomerAll wrapper ? wrapper.Value : null;
    public DiscountCustomerSegments? AsDiscountCustomerSegments() => this is DiscountCustomerSelectionDiscountCustomerSegments wrapper ? wrapper.Value : null;
    public DiscountCustomers? AsDiscountCustomers() => this is DiscountCustomerSelectionDiscountCustomers wrapper ? wrapper.Value : null;
}