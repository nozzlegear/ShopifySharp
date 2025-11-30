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

public class OrderRiskQueryBuilder() : GraphQueryBuilder<OrderRisk>("query orderRisk")
{
    [Obsolete("This field is deprecated in favor of OrderRiskAssessment.facts.")]
    public OrderRiskQueryBuilder AddFieldDisplay()
    {
        AddField("display");
        return this;
    }

    [Obsolete("This field is deprecated in favor of OrderRiskAssessment.riskLevel which allows for more granular risk levels, including PENDING and NONE.")]
    public OrderRiskQueryBuilder AddFieldLevel()
    {
        AddField("level");
        return this;
    }

    [Obsolete("This field is deprecated in favor of OrderRiskAssessment.facts.")]
    public OrderRiskQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}