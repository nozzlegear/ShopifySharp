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

public class MarketingEngagementsDeletePayloadQueryBuilder() : GraphQueryBuilder<MarketingEngagementsDeletePayload>("marketingEngagementsDeletePayload")
{
    public MarketingEngagementsDeletePayloadQueryBuilder AddFieldResult()
    {
        AddField("result");
        return this;
    }

    public MarketingEngagementsDeletePayloadQueryBuilder AddFieldUserErrors(Func<MarketingActivityUserErrorQueryBuilder, MarketingActivityUserErrorQueryBuilder> build)
    {
        AddField<MarketingActivityUserError, MarketingActivityUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}