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

public class ReturnCancelPayloadQueryBuilder() : GraphQueryBuilder<ReturnCancelPayload>("returnCancelPayload")
{
    public ReturnCancelPayloadQueryBuilder AddFieldReturn(Func<ReturnQueryBuilder, ReturnQueryBuilder> build)
    {
        AddField<Return, ReturnQueryBuilder>("return", build);
        return this;
    }

    public ReturnCancelPayloadQueryBuilder AddFieldUserErrors(Func<ReturnUserErrorQueryBuilder, ReturnUserErrorQueryBuilder> build)
    {
        AddField<ReturnUserError, ReturnUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}