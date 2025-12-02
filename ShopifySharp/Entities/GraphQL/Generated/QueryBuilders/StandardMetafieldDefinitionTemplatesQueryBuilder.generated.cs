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

public class StandardMetafieldDefinitionTemplatesQueryBuilder() : GraphQueryBuilder<StandardMetafieldDefinitionTemplateConnection>("standardMetafieldDefinitionTemplates"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public StandardMetafieldDefinitionTemplatesQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public StandardMetafieldDefinitionTemplatesQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public StandardMetafieldDefinitionTemplatesQueryBuilder AddArgumentConstraintStatus(MetafieldDefinitionConstraintStatus? constraintStatus)
    {
        AddArgument("constraintStatus", constraintStatus);
        return this;
    }

    public StandardMetafieldDefinitionTemplatesQueryBuilder AddArgumentConstraintSubtype(MetafieldDefinitionConstraintSubtypeIdentifier? constraintSubtype)
    {
        AddArgument("constraintSubtype", constraintSubtype);
        return this;
    }

    public StandardMetafieldDefinitionTemplatesQueryBuilder AddArgumentExcludeActivated(bool? excludeActivated)
    {
        AddArgument("excludeActivated", excludeActivated);
        return this;
    }

    public StandardMetafieldDefinitionTemplatesQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public StandardMetafieldDefinitionTemplatesQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public StandardMetafieldDefinitionTemplatesQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }
}