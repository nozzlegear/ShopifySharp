/// Original code from graphql-query-builder-dotnet by Charles de Vandière
/// Copyright (c) 2025 Charles de Vandière
/// Modifications copyright (c) 2025 Nozzlegear Software
/// Licensed under MIT License - see attributions.md
#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;

namespace ShopifySharp.Infrastructure;

internal static class RequiredArgument
{
    /// <summary>Verifies argument is not null.</summary>
    /// <param name="param">The parameter.</param>
    /// <param name="paramName">The parameter name.</param>
    /// <typeparam name="TArgument">The parameter type.</typeparam>
    internal static void NotNull<TArgument>(
        #if NET6_0_OR_GREATER
        [NotNull]
        #endif
        TArgument? param,
        string paramName)
    {
        if (param is null)
        {
            throw new ArgumentNullException(paramName);
        }
    }

    /// <summary>Verifies argument is not null or empty.</summary>
    /// <param name="param">The parameter.</param>
    /// <param name="paramName">The parameter name.</param>
    internal static void NotNullOrEmpty(
        #if NET6_0_OR_GREATER
        [NotNull]
        #endif
        string? param,
        string paramName
    )
    {
        NotNull(param, paramName);

        if (param.Length == 0)
        {
            throw new ArgumentException("Value cannot be empty.", paramName);
        }
    }
}
