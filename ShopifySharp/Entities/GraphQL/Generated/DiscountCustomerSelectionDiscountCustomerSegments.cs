#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

internal record DiscountCustomerSelectionDiscountCustomerSegments(DiscountCustomerSegments Value) : DiscountCustomerSelection;