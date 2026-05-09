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
/// Reason code for cash management.
/// </summary>
[JsonConverter(typeof(GraphUnionTypeConverter<CashManagementReasonCode>))]
public record CashManagementReasonCode : GraphQLObject<CashManagementReasonCode>, IGraphQLUnionType
{
    public CashManagementCustomReasonCode? AsCashManagementCustomReasonCode() => this is CashManagementReasonCodeCashManagementCustomReasonCode wrapper ? wrapper.Value : null;
    public CashManagementDefaultReasonCode? AsCashManagementDefaultReasonCode() => this is CashManagementReasonCodeCashManagementDefaultReasonCode wrapper ? wrapper.Value : null;
    public CashManagementSystemReasonCode? AsCashManagementSystemReasonCode() => this is CashManagementReasonCodeCashManagementSystemReasonCode wrapper ? wrapper.Value : null;
}