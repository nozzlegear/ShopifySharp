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

public class FulfillmentOrderSubmitFulfillmentRequestPayloadQueryBuilder() : GraphQueryBuilder<FulfillmentOrderSubmitFulfillmentRequestPayload>("fulfillmentOrderSubmitFulfillmentRequestPayload")
{
    public FulfillmentOrderSubmitFulfillmentRequestPayloadQueryBuilder AddFieldOriginalFulfillmentOrder(Func<FulfillmentOrderQueryBuilder, FulfillmentOrderQueryBuilder> build)
    {
        AddField<FulfillmentOrder, FulfillmentOrderQueryBuilder>("originalFulfillmentOrder", build);
        return this;
    }

    public FulfillmentOrderSubmitFulfillmentRequestPayloadQueryBuilder AddFieldSubmittedFulfillmentOrder(Func<FulfillmentOrderQueryBuilder, FulfillmentOrderQueryBuilder> build)
    {
        AddField<FulfillmentOrder, FulfillmentOrderQueryBuilder>("submittedFulfillmentOrder", build);
        return this;
    }

    public FulfillmentOrderSubmitFulfillmentRequestPayloadQueryBuilder AddFieldUnsubmittedFulfillmentOrder(Func<FulfillmentOrderQueryBuilder, FulfillmentOrderQueryBuilder> build)
    {
        AddField<FulfillmentOrder, FulfillmentOrderQueryBuilder>("unsubmittedFulfillmentOrder", build);
        return this;
    }

    public FulfillmentOrderSubmitFulfillmentRequestPayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}