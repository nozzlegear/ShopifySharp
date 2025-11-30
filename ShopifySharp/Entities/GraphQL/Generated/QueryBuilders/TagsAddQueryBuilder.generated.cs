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

public class TagsAddQueryBuilder() : GraphQueryBuilder<TagsAddPayload>("tagsAdd"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public TagsAddQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public TagsAddQueryBuilder AddArgumentTags(ICollection<string>? tags)
    {
        AddArgument("tags", tags);
        return this;
    }
}