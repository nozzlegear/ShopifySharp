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

public class SellingPlanGroupCreateQueryBuilder() : GraphQueryBuilder<SellingPlanGroupCreatePayload>("query sellingPlanGroupCreate")
{
    public SellingPlanGroupCreateQueryBuilder AddArgumentInput(SellingPlanGroupInput? input)
    {
        AddArgument("input", input);
        return this;
    }

    public SellingPlanGroupCreateQueryBuilder AddArgumentResources(SellingPlanGroupResourceInput? resources)
    {
        AddArgument("resources", resources);
        return this;
    }
}