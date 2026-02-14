/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using System.Collections.Generic;
using JetBrains.Annotations;

namespace ShopifySharp.GraphQL.QueryBuilders;

[PublicAPI]
public abstract class ArgumentsBuilderBase<TSource, TSelf>(IQuery<TSource> query) : IArgumentsBuilder<TSelf>
    where TSelf : IArgumentsBuilder<TSelf>
{
    protected readonly IQuery<TSource> InnerQuery = query;

    protected abstract TSelf Self { get; }

    public TSelf AddArgument(string key, object? value)
    {
        InnerQuery.AddArgument(key, value);
        return Self;
    }

    public TSelf AddArguments(IDictionary<string, object?> arguments)
    {
        InnerQuery.AddArguments(arguments);
        return Self;
    }
}
