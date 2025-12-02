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

public class StoreCreditAccountEdgeQueryBuilder() : GraphQueryBuilder<StoreCreditAccountEdge>("storeCreditAccountEdge")
{
    public StoreCreditAccountEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public StoreCreditAccountEdgeQueryBuilder AddFieldNode(Func<StoreCreditAccountQueryBuilder, StoreCreditAccountQueryBuilder> build)
    {
        AddField<StoreCreditAccount, StoreCreditAccountQueryBuilder>("node", build);
        return this;
    }
}