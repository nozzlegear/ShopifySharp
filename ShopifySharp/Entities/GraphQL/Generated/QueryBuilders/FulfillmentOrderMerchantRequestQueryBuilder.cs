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

public class FulfillmentOrderMerchantRequestQueryBuilder() : GraphQueryBuilder<FulfillmentOrderMerchantRequest>("query fulfillmentOrderMerchantRequest")
{
    public FulfillmentOrderMerchantRequestQueryBuilder AddFieldFulfillmentOrder()
    {
        AddField("fulfillmentOrder");
        return this;
    }

    public FulfillmentOrderMerchantRequestQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public FulfillmentOrderMerchantRequestQueryBuilder AddFieldKind()
    {
        AddField("kind");
        return this;
    }

    public FulfillmentOrderMerchantRequestQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }

    public FulfillmentOrderMerchantRequestQueryBuilder AddFieldRequestOptions()
    {
        AddField("requestOptions");
        return this;
    }

    public FulfillmentOrderMerchantRequestQueryBuilder AddFieldResponseData()
    {
        AddField("responseData");
        return this;
    }

    public FulfillmentOrderMerchantRequestQueryBuilder AddFieldSentAt()
    {
        AddField("sentAt");
        return this;
    }
}