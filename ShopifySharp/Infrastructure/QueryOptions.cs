/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using System;
using System.Reflection;

namespace ShopifySharp.Infrastructure;

public class QueryOptions
{
    /// <summary>Gets or sets the property name formatter.</summary>
    public Func<PropertyInfo, string>? Formatter { get; set; }

    /// <summary>Gets or sets the query string builder factory.</summary>
    public Func<IQueryStringBuilder>? QueryStringBuilderFactory { get; set; }
}
