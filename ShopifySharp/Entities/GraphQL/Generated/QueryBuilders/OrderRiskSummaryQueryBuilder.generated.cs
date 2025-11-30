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

public class OrderRiskSummaryQueryBuilder() : GraphQueryBuilder<OrderRiskSummary>("orderRiskSummary")
{
    public OrderRiskSummaryQueryBuilder AddFieldAssessments(Func<OrderRiskAssessmentQueryBuilder, OrderRiskAssessmentQueryBuilder> build)
    {
        AddField<OrderRiskAssessment, OrderRiskAssessmentQueryBuilder>("assessments", build);
        return this;
    }

    public OrderRiskSummaryQueryBuilder AddFieldRecommendation()
    {
        AddField("recommendation");
        return this;
    }
}