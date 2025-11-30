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

public class MetafieldDefinitionsQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionConnection>("metafieldDefinitions"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public MetafieldDefinitionsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public MetafieldDefinitionsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public MetafieldDefinitionsQueryBuilder AddArgumentConstraintStatus(MetafieldDefinitionConstraintStatus? constraintStatus)
    {
        AddArgument("constraintStatus", constraintStatus);
        return this;
    }

    public MetafieldDefinitionsQueryBuilder AddArgumentConstraintSubtype(MetafieldDefinitionConstraintSubtypeIdentifier? constraintSubtype)
    {
        AddArgument("constraintSubtype", constraintSubtype);
        return this;
    }

    public MetafieldDefinitionsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public MetafieldDefinitionsQueryBuilder AddArgumentKey(string? key)
    {
        AddArgument("key", key);
        return this;
    }

    public MetafieldDefinitionsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public MetafieldDefinitionsQueryBuilder AddArgumentNamespace(string? @namespace)
    {
        AddArgument("namespace", @namespace);
        return this;
    }

    public MetafieldDefinitionsQueryBuilder AddArgumentOwnerType(MetafieldOwnerType? ownerType)
    {
        AddArgument("ownerType", ownerType);
        return this;
    }

    public MetafieldDefinitionsQueryBuilder AddArgumentPinnedStatus(MetafieldDefinitionPinnedStatus? pinnedStatus)
    {
        AddArgument("pinnedStatus", pinnedStatus);
        return this;
    }

    public MetafieldDefinitionsQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public MetafieldDefinitionsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public MetafieldDefinitionsQueryBuilder AddArgumentSortKey(MetafieldDefinitionSortKeys? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }
}