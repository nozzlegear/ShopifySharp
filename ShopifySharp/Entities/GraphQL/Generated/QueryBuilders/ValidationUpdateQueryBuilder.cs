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

public class ValidationUpdateQueryBuilder() : GraphQueryBuilder<ValidationUpdatePayload>("query validationUpdate")
{
    public ValidationUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public ValidationUpdateQueryBuilder AddArgumentValidation(ValidationUpdateInput? validation)
    {
        AddArgument("validation", validation);
        return this;
    }
}