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

public class OrderRiskAssessmentCreateUserErrorQueryBuilder() : GraphQueryBuilder<OrderRiskAssessmentCreateUserError>("query orderRiskAssessmentCreateUserError")
{
    public OrderRiskAssessmentCreateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public OrderRiskAssessmentCreateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public OrderRiskAssessmentCreateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}