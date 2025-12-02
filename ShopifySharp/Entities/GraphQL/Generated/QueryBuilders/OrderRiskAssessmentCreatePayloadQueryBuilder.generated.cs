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

public class OrderRiskAssessmentCreatePayloadQueryBuilder() : GraphQueryBuilder<OrderRiskAssessmentCreatePayload>("orderRiskAssessmentCreatePayload")
{
    public OrderRiskAssessmentCreatePayloadQueryBuilder AddFieldOrderRiskAssessment(Func<OrderRiskAssessmentQueryBuilder, OrderRiskAssessmentQueryBuilder> build)
    {
        AddField<OrderRiskAssessment, OrderRiskAssessmentQueryBuilder>("orderRiskAssessment", build);
        return this;
    }

    public OrderRiskAssessmentCreatePayloadQueryBuilder AddFieldUserErrors(Func<OrderRiskAssessmentCreateUserErrorQueryBuilder, OrderRiskAssessmentCreateUserErrorQueryBuilder> build)
    {
        AddField<OrderRiskAssessmentCreateUserError, OrderRiskAssessmentCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}