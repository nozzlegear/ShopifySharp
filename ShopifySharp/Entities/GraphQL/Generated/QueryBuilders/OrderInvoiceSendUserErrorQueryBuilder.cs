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

public class OrderInvoiceSendUserErrorQueryBuilder() : GraphQueryBuilder<OrderInvoiceSendUserError>("query orderInvoiceSendUserError")
{
    public OrderInvoiceSendUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public OrderInvoiceSendUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public OrderInvoiceSendUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}