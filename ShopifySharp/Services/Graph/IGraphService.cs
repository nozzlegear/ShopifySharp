#nullable enable
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ShopifySharp.Services.Graph;

namespace ShopifySharp;

public interface IGraphService : IShopifyService
{
    /// <summary>
    /// Executes the GraphQL API call using the query and variables described in <paramref name="graphRequest" />. This
    /// query automatically scopes the response from Shopify to the <c>data</c> property and deserializes it to type
    /// <typeparamref name="T"/>.
    /// </summary>
    /// <param name="graphRequest">
    /// An object containing the GraphQL query to be executed. Variables are optional.
    /// Use <see cref="GraphRequest.EstimatedQueryCost" /> to provide an estimated query cost to any
    /// <see cref="IRequestExecutionPolicy" />, to avoid sending a request that will be throttled.
    /// </param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>
    /// A <see cref="GraphResult{T}"/> of type <typeparamref name="T"/>. The <see cref="GraphResult{T}.Data"/> value
    /// will be scoped to the <c>data</c> property of the graph response.
    /// </returns>
    Task<GraphResult<T>> PostAsync<T>(GraphRequest graphRequest, CancellationToken cancellationToken = default);

    /// <summary>
    /// Executes the GraphQL API call using the query and variables described in <paramref name="graphRequest" />. This
    /// query does not automatically scope or deserialize the response from Shopify.
    /// </summary>
    /// <param name="graphRequest">
    /// An object containing the GraphQL query to be executed. Variables are optional.
    /// Use <see cref="GraphRequest.EstimatedQueryCost" /> to provide an estimated query cost to any
    /// <see cref="IRequestExecutionPolicy" />, to avoid sending a request that will be throttled.
    /// </param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>A GraphResult with a <see cref="JsonDocument"/> scoped to the root of the graph response.</returns>
    Task<GraphResult> PostAsync(GraphRequest graphRequest, CancellationToken cancellationToken = default);

    /// <summary>
    /// Executes the GraphQL API call using the query and variables described in <paramref name="graphRequest" />. This
    /// query automatically scopes the response from Shopify to the <c>data</c> property and coerces it to the type
    /// of <paramref name="resultType"/>.
    /// </summary>
    /// <param name="graphRequest">
    /// An object containing the GraphQL query to be executed. Variables are optional.
    /// Use <see cref="GraphRequest.EstimatedQueryCost" /> to provide an estimated query cost to any
    /// <see cref="IRequestExecutionPolicy" />, to avoid sending a request that will be throttled.
    /// </param>
    /// <param name="resultType"></param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>
    /// A <see cref="GraphResult{T}"/> of type <see cref="object"/>. The <see cref="GraphResult{T}.Data"/> value
    /// will be scoped to the <c>data</c> property of the graph response and coerced to the type of
    /// <paramref name="resultType"/>.
    /// </returns>
    Task<GraphResult<object>> PostAsync(GraphRequest graphRequest, Type resultType, CancellationToken cancellationToken = default);

    #region Deprecated methods

    /// <summary>
    /// Executes a Graph API Call.
    /// </summary>
    /// <param name="body">The query you would like to execute. Please see documentation for formatting.</param>
    /// <param name="graphqlQueryCost">
    /// The requestedQueryCost available at extensions.cost.requestedQueryCost.
    /// While it is optional, it is recommended to provide it to avoid wasting resources to issue API calls that will be throttled
    /// </param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>A JToken containing the data from the request.</returns>
    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    Task<JToken> PostAsync(string body, int? graphqlQueryCost = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Executes a Graph API Call.
    /// </summary>
    /// <param name="body">The query you would like to execute, as a JToken. Please see documentation for formatting.</param>
    /// <param name="graphqlQueryCost">
    /// The requestedQueryCost available at extensions.cost.requestedQueryCost.
    /// While it is optional, it is recommended to provide it to avoid wasting resources to issue API calls that will be throttled
    /// </param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>A JToken containing the data from the request.</returns>
    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    Task<JToken> PostAsync(JToken body, int? graphqlQueryCost = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Executes a Graph API Call.
    /// </summary>
    /// <param name="graphRequest">An object containing the GraphQL query to be executed. Variables are optional. Use <see cref="GraphRequest.EstimatedQueryCost" /> to provide an estimated query cost to any <see cref="IRequestExecutionPolicy" />, to avoid sending a request that will be throttled.</param>
    /// <param name="graphqlQueryCost">
    /// The requestedQueryCost available at extensions.cost.requestedQueryCost.
    /// While it is optional, it is recommended to provide it to avoid wasting resources to issue API calls that will be throttled
    /// </param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>A JsonElement containing the data from the request.</returns>
    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    Task<JsonElement> SendAsync(GraphRequest graphRequest, int? graphqlQueryCost = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Executes a Graph API Call.
    /// </summary>
    /// <param name="graphqlQuery">The query you would like to execute, as a string. Please see documentation for formatting.</param>
    /// <param name="graphqlQueryCost">
    /// The requestedQueryCost available at extensions.cost.requestedQueryCost.
    /// While it is optional, it is recommended to provide it to avoid wasting resources to issue API calls that will be throttled
    /// </param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>A JsonElement containing the data from the request.</returns>
    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    Task<JsonElement> SendAsync(string graphqlQuery, int? graphqlQueryCost = null,
        CancellationToken cancellationToken = default);

#if NET6_0_OR_GREATER
    /// <summary>
    /// Executes a Graph API Call.
    /// </summary>
    /// <param name="graphRequest">An object containing the GraphQL query to be executed. Variables are optional. Use <see cref="GraphRequest.EstimatedQueryCost" /> to provide an estimated query cost to any <see cref="IRequestExecutionPolicy" />, to avoid sending a request that will be throttled.</param>
    /// <param name="graphqlQueryCost">
    /// The requestedQueryCost available at extensions.cost.requestedQueryCost.
    /// While it is optional, it is recommended to provide it to avoid wasting resources to issue API calls that will be throttled
    /// </param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>A <see cref="TResult"/> containing the data from the request.</returns>
    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    Task<TResult> SendAsync<TResult>(GraphRequest graphRequest, int? graphqlQueryCost = null, CancellationToken cancellationToken = default) where TResult : class;

    /// <summary>
    /// Executes a Graph API Call.
    /// </summary>
    /// <param name="graphqlQuery">The query you would like to execute, as a string. Please see documentation for formatting.</param>
    /// <param name="graphqlQueryCost">
    /// The requestedQueryCost available at extensions.cost.requestedQueryCost.
    /// While it is optional, it is recommended to provide it to avoid wasting resources to issue API calls that will be throttled
    /// </param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>A <see cref="TResult"/> containing the data from the request.</returns>
    [Obsolete("This method is deprecated and will be removed in a future version of ShopifySharp.")]
    Task<TResult> SendAsync<TResult>(string graphqlQuery, int? graphqlQueryCost = null, CancellationToken cancellationToken = default) where TResult : class;
#endif

    #endregion
}
