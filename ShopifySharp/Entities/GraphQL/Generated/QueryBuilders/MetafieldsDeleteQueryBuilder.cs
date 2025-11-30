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

public class MetafieldsDeleteQueryBuilder() : GraphQueryBuilder<MetafieldsDeletePayload>("query metafieldsDelete")
{
    public MetafieldsDeleteQueryBuilder AddArgumentMetafields(ICollection<MetafieldIdentifierInput>? metafields)
    {
        AddArgument("metafields", metafields);
        return this;
    }
}