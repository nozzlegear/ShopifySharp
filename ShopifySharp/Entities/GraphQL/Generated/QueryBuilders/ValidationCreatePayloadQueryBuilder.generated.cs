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

public class ValidationCreatePayloadQueryBuilder() : GraphQueryBuilder<ValidationCreatePayload>("validationCreatePayload")
{
    public ValidationCreatePayloadQueryBuilder AddFieldUserErrors(Func<ValidationUserErrorQueryBuilder, ValidationUserErrorQueryBuilder> build)
    {
        AddField<ValidationUserError, ValidationUserErrorQueryBuilder>("userErrors", build);
        return this;
    }

    public ValidationCreatePayloadQueryBuilder AddFieldValidation(Func<ValidationQueryBuilder, ValidationQueryBuilder> build)
    {
        AddField<Validation, ValidationQueryBuilder>("validation", build);
        return this;
    }
}