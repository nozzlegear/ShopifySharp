#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class OrderInvoiceSendQueryBuilder() : GraphQueryBuilder<OrderInvoiceSendPayload>("orderInvoiceSend"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

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