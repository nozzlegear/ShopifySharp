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

public class IHasMetafieldDefinitionsQueryBuilder() : GraphQueryBuilder<IHasMetafieldDefinitions>("query iHasMetafieldDefinitions")
{
    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public IHasMetafieldDefinitionsQueryBuilder AddFieldMetafieldDefinitions()
    {
        AddField("metafieldDefinitions");
        return this;
    }
}