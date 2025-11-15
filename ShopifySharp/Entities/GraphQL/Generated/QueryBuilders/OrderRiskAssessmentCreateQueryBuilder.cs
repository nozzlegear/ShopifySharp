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

public class OrderRiskAssessmentCreateQueryBuilder() : GraphQueryBuilder<OrderRiskAssessmentCreatePayload>("query orderRiskAssessmentCreate")
{
    public OrderRiskAssessmentCreateQueryBuilder AddArgumentOrderRiskAssessmentInput(OrderRiskAssessmentCreateInput? orderRiskAssessmentInput)
    {
        AddArgument("orderRiskAssessmentInput", orderRiskAssessmentInput);
        return this;
    }
}