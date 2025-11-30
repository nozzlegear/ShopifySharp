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

public class MetaobjectDefinitionsQueryBuilder() : GraphQueryBuilder<MetaobjectDefinitionConnection>("metaobjectDefinitions"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public MetaobjectDefinitionsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public MetaobjectDefinitionsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public MetaobjectDefinitionsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public MetaobjectDefinitionsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public MetaobjectDefinitionsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }
}