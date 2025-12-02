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

public class PubSubServerPixelUpdateQueryBuilder() : GraphQueryBuilder<PubSubServerPixelUpdatePayload>("pubSubServerPixelUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public PubSubServerPixelUpdateQueryBuilder AddArgumentPubSubProject(string? pubSubProject)
    {
        AddArgument("pubSubProject", pubSubProject);
        return this;
    }

    public PubSubServerPixelUpdateQueryBuilder AddArgumentPubSubTopic(string? pubSubTopic)
    {
        AddArgument("pubSubTopic", pubSubTopic);
        return this;
    }
}