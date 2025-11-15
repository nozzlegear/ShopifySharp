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

public class OrderInvoiceSendQueryBuilder() : GraphQueryBuilder<OrderInvoiceSendPayload>("query orderInvoiceSend")
{
    public OrderInvoiceSendQueryBuilder AddArgumentEmail(EmailInput? email)
    {
        AddArgument("email", email);
        return this;
    }

    public OrderInvoiceSendQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}