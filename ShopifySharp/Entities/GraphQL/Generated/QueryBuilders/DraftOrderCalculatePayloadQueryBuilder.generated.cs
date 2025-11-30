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

public class DraftOrderCalculatePayloadQueryBuilder() : GraphQueryBuilder<DraftOrderCalculatePayload>("draftOrderCalculatePayload")
{
    public DraftOrderCalculatePayloadQueryBuilder AddFieldCalculatedDraftOrder(Func<CalculatedDraftOrderQueryBuilder, CalculatedDraftOrderQueryBuilder> build)
    {
        AddField<CalculatedDraftOrder, CalculatedDraftOrderQueryBuilder>("calculatedDraftOrder", build);
        return this;
    }

    public DraftOrderCalculatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}