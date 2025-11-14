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
