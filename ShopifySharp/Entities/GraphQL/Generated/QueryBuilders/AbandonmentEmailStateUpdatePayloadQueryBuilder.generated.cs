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

public class AbandonmentEmailStateUpdatePayloadQueryBuilder() : GraphQueryBuilder<AbandonmentEmailStateUpdatePayload>("abandonmentEmailStateUpdatePayload")
{
    public AbandonmentEmailStateUpdatePayloadQueryBuilder AddFieldAbandonment(Func<AbandonmentQueryBuilder, AbandonmentQueryBuilder> build)
    {
        AddField<Abandonment, AbandonmentQueryBuilder>("abandonment", build);
        return this;
    }

    public AbandonmentEmailStateUpdatePayloadQueryBuilder AddFieldUserErrors(Func<AbandonmentEmailStateUpdateUserErrorQueryBuilder, AbandonmentEmailStateUpdateUserErrorQueryBuilder> build)
    {
        AddField<AbandonmentEmailStateUpdateUserError, AbandonmentEmailStateUpdateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}