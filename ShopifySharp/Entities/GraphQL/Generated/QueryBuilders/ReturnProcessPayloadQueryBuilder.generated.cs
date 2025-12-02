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

public class ReturnProcessPayloadQueryBuilder() : GraphQueryBuilder<ReturnProcessPayload>("returnProcessPayload")
{
    public ReturnProcessPayloadQueryBuilder AddFieldReturn(Func<ReturnQueryBuilder, ReturnQueryBuilder> build)
    {
        AddField<Return, ReturnQueryBuilder>("return", build);
        return this;
    }

    public ReturnProcessPayloadQueryBuilder AddFieldUserErrors(Func<ReturnUserErrorQueryBuilder, ReturnUserErrorQueryBuilder> build)
    {
        AddField<ReturnUserError, ReturnUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}