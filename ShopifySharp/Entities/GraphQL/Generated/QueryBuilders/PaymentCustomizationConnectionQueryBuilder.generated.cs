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

public class PaymentCustomizationConnectionQueryBuilder() : GraphQueryBuilder<PaymentCustomizationConnection>("paymentCustomizationConnection")
{
    public PaymentCustomizationConnectionQueryBuilder AddFieldEdges(Func<PaymentCustomizationEdgeQueryBuilder, PaymentCustomizationEdgeQueryBuilder> build)
    {
        AddField<PaymentCustomizationEdge, PaymentCustomizationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public PaymentCustomizationConnectionQueryBuilder AddFieldNodes(Func<PaymentCustomizationQueryBuilder, PaymentCustomizationQueryBuilder> build)
    {
        AddField<PaymentCustomization, PaymentCustomizationQueryBuilder>("nodes", build);
        return this;
    }

    public PaymentCustomizationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}