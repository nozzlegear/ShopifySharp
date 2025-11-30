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

public class MetafieldDefinitionUpdateUserErrorQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionUpdateUserError>("metafieldDefinitionUpdateUserError")
{
    public MetafieldDefinitionUpdateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public MetafieldDefinitionUpdateUserErrorQueryBuilder AddFieldElementIndex()
    {
        AddField("elementIndex");
        return this;
    }

    public MetafieldDefinitionUpdateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public MetafieldDefinitionUpdateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}