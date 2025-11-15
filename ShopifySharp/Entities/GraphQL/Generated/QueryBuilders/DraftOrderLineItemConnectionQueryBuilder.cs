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

public class DraftOrderLineItemConnectionQueryBuilder() : GraphQueryBuilder<DraftOrderLineItemConnection>("query draftOrderLineItemConnection")
{
    public DraftOrderLineItemConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public DraftOrderLineItemConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public DraftOrderLineItemConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}