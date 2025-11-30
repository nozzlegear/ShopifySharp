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

public class ExchangeLineItemQueryBuilder() : GraphQueryBuilder<ExchangeLineItem>("query exchangeLineItem")
{
    public ExchangeLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    [Obsolete("Use `lineItems` instead.")]
    public ExchangeLineItemQueryBuilder AddFieldLineItem()
    {
        AddField("lineItem");
        return this;
    }

    public ExchangeLineItemQueryBuilder AddFieldLineItems()
    {
        AddField("lineItems");
        return this;
    }

    public ExchangeLineItemQueryBuilder AddFieldProcessableQuantity()
    {
        AddField("processableQuantity");
        return this;
    }

    public ExchangeLineItemQueryBuilder AddFieldProcessedQuantity()
    {
        AddField("processedQuantity");
        return this;
    }

    public ExchangeLineItemQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public ExchangeLineItemQueryBuilder AddFieldUnprocessedQuantity()
    {
        AddField("unprocessedQuantity");
        return this;
    }

    public ExchangeLineItemQueryBuilder AddFieldVariantId()
    {
        AddField("variantId");
        return this;
    }
}