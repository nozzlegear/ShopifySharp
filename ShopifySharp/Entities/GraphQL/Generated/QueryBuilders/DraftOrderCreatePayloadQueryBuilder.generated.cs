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

public class DraftOrderCreatePayloadQueryBuilder() : GraphQueryBuilder<DraftOrderCreatePayload>("draftOrderCreatePayload")
{
    public DraftOrderCreatePayloadQueryBuilder AddFieldDraftOrder(Func<DraftOrderQueryBuilder, DraftOrderQueryBuilder> build)
    {
        AddField<DraftOrder, DraftOrderQueryBuilder>("draftOrder", build);
        return this;
    }

    public DraftOrderCreatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}