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

public class MetafieldDefinitionConstraintsQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionConstraints>("metafieldDefinitionConstraints")
{
    public MetafieldDefinitionConstraintsQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public MetafieldDefinitionConstraintsQueryBuilder AddFieldValues(Func<MetafieldDefinitionConstraintValueConnectionQueryBuilder, MetafieldDefinitionConstraintValueConnectionQueryBuilder> build)
    {
        AddField<MetafieldDefinitionConstraintValueConnection, MetafieldDefinitionConstraintValueConnectionQueryBuilder>("values", build);
        return this;
    }
}