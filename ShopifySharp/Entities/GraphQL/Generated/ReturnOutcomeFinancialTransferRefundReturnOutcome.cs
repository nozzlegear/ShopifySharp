#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

internal record ReturnOutcomeFinancialTransferRefundReturnOutcome(RefundReturnOutcome Value) : ReturnOutcomeFinancialTransfer;