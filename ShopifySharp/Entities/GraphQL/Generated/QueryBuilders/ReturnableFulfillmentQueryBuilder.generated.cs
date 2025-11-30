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

public class ReturnableFulfillmentQueryBuilder() : GraphQueryBuilder<ReturnableFulfillment>("returnableFulfillment")
{
    public ReturnableFulfillmentQueryBuilder AddFieldFulfillment(Func<FulfillmentQueryBuilder, FulfillmentQueryBuilder> build)
    {
        AddField<Fulfillment, FulfillmentQueryBuilder>("fulfillment", build);
        return this;
    }

    public ReturnableFulfillmentQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ReturnableFulfillmentQueryBuilder AddFieldReturnableFulfillmentLineItems(Func<ReturnableFulfillmentLineItemConnectionQueryBuilder, ReturnableFulfillmentLineItemConnectionQueryBuilder> build)
    {
        AddField<ReturnableFulfillmentLineItemConnection, ReturnableFulfillmentLineItemConnectionQueryBuilder>("returnableFulfillmentLineItems", build);
        return this;
    }
}