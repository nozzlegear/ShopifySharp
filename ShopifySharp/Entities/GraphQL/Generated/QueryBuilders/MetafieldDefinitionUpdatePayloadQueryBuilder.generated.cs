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

public class MetafieldDefinitionUpdatePayloadQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionUpdatePayload>("metafieldDefinitionUpdatePayload")
{
    public MetafieldDefinitionUpdatePayloadQueryBuilder AddFieldUpdatedDefinition(Func<MetafieldDefinitionQueryBuilder, MetafieldDefinitionQueryBuilder> build)
    {
        AddField<MetafieldDefinition, MetafieldDefinitionQueryBuilder>("updatedDefinition", build);
        return this;
    }

    public MetafieldDefinitionUpdatePayloadQueryBuilder AddFieldUserErrors(Func<MetafieldDefinitionUpdateUserErrorQueryBuilder, MetafieldDefinitionUpdateUserErrorQueryBuilder> build)
    {
        AddField<MetafieldDefinitionUpdateUserError, MetafieldDefinitionUpdateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }

    public MetafieldDefinitionUpdatePayloadQueryBuilder AddFieldValidationJob(Func<JobQueryBuilder, JobQueryBuilder> build)
    {
        AddField<Job, JobQueryBuilder>("validationJob", build);
        return this;
    }
}