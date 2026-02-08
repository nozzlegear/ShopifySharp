#nullable enable
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ShopifySharp.GraphQL;
using ShopifySharp.Services.Graph;

namespace ShopifySharp;

public interface IGraphService : IShopifyService
{
    /// <summary>
    /// Executes the GraphQL API call using the query and variables described in <paramref name="graphRequest" />.
    /// If the response contains a single top-level property matching the type name, it will be automatically unwrapped
    /// and deserialized to <typeparamref name="T"/>.
    /// </summary>
    /// <param name="graphRequest">
    /// An object containing the GraphQL query to be executed. Variables are optional.
    /// Use <see cref="GraphRequest.EstimatedQueryCost" /> to provide an estimated query cost to any
    /// <see cref="IRequestExecutionPolicy" />, to avoid sending a request that will be throttled.
    /// </param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <typeparam name="T">
    /// The type to deserialize the response data into. Can be either:
    /// <list type="bullet">
    /// <item>A direct GraphQL object type (e.g. BulkOperation) for automatic unwrapping</item>
    /// <item>A wrapper class with properties matching response keys for explicit structure</item>
    /// </list>
    /// </typeparam>
    /// <example>
    /// <para>
    /// Direct deserialization (recommended):
    /// </para>
    /// <code lang="cs">
    /// var result = await service.PostAsync&lt;BulkOperation&gt;(new GraphRequest
    /// {
    ///     Query = "query { bulkOperation(id: $id) { id status } }"
    /// });
    /// var operation = result.Data; // type is BulkOperation
    /// </code>
    /// <para>
    /// Explicit wrapper (recommended when querying more than one top-level property or operation):
    /// </para>
    /// <code lang="cs">
    /// public record Wrapper
    /// {
    ///     public BulkOperation BulkOperation { get; set; }
    ///     public Shop Shop { get; set; }
    /// }
    /// var result = await service.PostAsync&lt;Wrapper&gt;(new GraphRequest
    /// {
    ///     Query = "query { bulkOperation(id: $id) { id status } shop { id name } }"
    /// });
    /// var result = await service.PostAsync&lt;Wrapper&gt;(request);
    /// var operation = result.Data.BulkOperation;
    /// var shop = result.Data.Shop;
    /// </code>
    /// </example>
    /// <returns>
    /// A <see cref="GraphResult{T}"/> of type <typeparamref name="T"/>.
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
    Task<GraphResult<T>> PostAsync<T>(GraphRequest<T> graphRequest, CancellationToken cancellationToken = default)
        where T : IGraphQLObject;
}
