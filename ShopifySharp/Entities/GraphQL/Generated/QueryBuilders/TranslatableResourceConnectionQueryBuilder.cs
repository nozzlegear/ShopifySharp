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

public class TranslatableResourceConnectionQueryBuilder() : GraphQueryBuilder<TranslatableResourceConnection>("query translatableResourceConnection")
{
    public TranslatableResourceConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public TranslatableResourceConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public TranslatableResourceConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}