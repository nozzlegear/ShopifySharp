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

public class TagsRemovePayloadQueryBuilder() : GraphQueryBuilder<TagsRemovePayload>("tagsRemovePayload")
{
    public TagsRemovePayloadQueryBuilder AddFieldNode(Func<NodeQueryBuilder, NodeQueryBuilder> build)
    {
        AddField<INode, NodeQueryBuilder>("node", build);
        return this;
    }

    public TagsRemovePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}