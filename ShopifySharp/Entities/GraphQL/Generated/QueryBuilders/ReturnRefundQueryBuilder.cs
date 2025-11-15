#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

[Obsolete("Use `returnProcess` instead.")]
public class ReturnRefundQueryBuilder() : GraphQueryBuilder<ReturnRefundPayload>("query returnRefund")
{
    public ReturnRefundQueryBuilder AddArgumentReturnRefundInput(ReturnRefundInput? returnRefundInput)
    {
        AddArgument("returnRefundInput", returnRefundInput);
        return this;
    }
}