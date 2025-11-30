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

public class ValidationDeletePayloadQueryBuilder() : GraphQueryBuilder<ValidationDeletePayload>("validationDeletePayload")
{
    public ValidationDeletePayloadQueryBuilder AddFieldDeletedId()
    {
        AddField("deletedId");
        return this;
    }

    public ValidationDeletePayloadQueryBuilder AddFieldUserErrors(Func<ValidationUserErrorQueryBuilder, ValidationUserErrorQueryBuilder> build)
    {
        AddField<ValidationUserError, ValidationUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}