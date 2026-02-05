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
/// The set of valid sort keys for the Transfer query.
/// </summary>
public enum TransferSortKeys
{
    CREATED_AT,
    DESTINATION_NAME,
    EXPECTED_SHIPMENT_ARRIVAL,
    ID,
    NAME,
    ORIGIN_NAME,
    SOURCE_NAME,
    STATUS,
}