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

public class ValidationUpdatePayloadQueryBuilder() : GraphQueryBuilder<ValidationUpdatePayload>("query validationUpdatePayload")
{
    public ValidationUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }

    public ValidationUpdatePayloadQueryBuilder AddFieldValidation()
    {
        AddField("validation");
        return this;
    }
}