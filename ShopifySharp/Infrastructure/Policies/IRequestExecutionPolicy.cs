using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

// ReSharper disable once CheckNamespace
namespace ShopifySharp;

public delegate Task<RequestResult<T>> ExecuteRequestAsync<T>(CloneableRequestMessage request);

/// <summary>
/// Used to specify centralized logic that should run when executing shopify requests.
/// It is most useful to implement retry logic, but it can also be used for other concerns (i.e. tracing)
/// </summary>
public interface IRequestExecutionPolicy
{
    /// <param name="baseRequestMessage">The base request that was built by a service to execute.</param>
    /// <param name="executeRequestAsync">A delegate that executes the request you pass to it.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <param name="graphqlQueryCost">Optional expected Graphql query cost (as seen in GraphQL response at extensions.cost.requestedQueryCost</param>
    Task<RequestResult<T>> Run<T>(CloneableRequestMessage baseRequestMessage, ExecuteRequestAsync<T> executeRequestAsync, CancellationToken cancellationToken, int? graphqlQueryCost = null);
}
