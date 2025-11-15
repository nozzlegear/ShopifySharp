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

public class OrderRiskAssessmentCreatePayloadQueryBuilder() : GraphQueryBuilder<OrderRiskAssessmentCreatePayload>("query orderRiskAssessmentCreatePayload")
{
    public OrderRiskAssessmentCreatePayloadQueryBuilder AddFieldOrderRiskAssessment()
    {
        AddField("orderRiskAssessment");
        return this;
    }

    public OrderRiskAssessmentCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}