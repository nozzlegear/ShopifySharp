using Flurl.Http;
using System.Net.Http;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    public delegate Task<RequestResult<T>> ExecuteRequestAsync<T>(IFlurlClient request, HttpContent bodyContent = null);

    /// <summary>
    /// Used to specify centralized logic that should run when executing shopify requests.
    /// It is most useful to implement retry logic, but it can also be used for other concerns (i.e. tracing)
    /// </summary>
    public interface IRequestExecutionPolicy
    {
        /// <param name="baseRequest">The base request that was built by a service to execute. Requests can be reused with <see cref="IFlurlClient.Clone"/>.</param>
        /// <param name="bodyContent">The request's body content, typically an instance of <see cref="StringContent"/>. This may be null depending on the request method.</param>
        /// <param name="executeRequestAsync">A delegate that executes the request you pass to it.</param>
        Task<T> Run<T>(IFlurlClient baseRequest, JsonContent bodyContent, ExecuteRequestAsync<T> executeRequestAsync);
    }
}
