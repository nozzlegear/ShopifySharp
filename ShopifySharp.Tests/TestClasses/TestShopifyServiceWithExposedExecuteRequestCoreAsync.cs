using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Tests.TestClasses;

public class TestShopifyServiceWithExposedExecuteRequestCoreAsync()
    : ShopifyService("some-shop-domain", "some-access-token")
{
    public new Task<RequestResult<string>> ExecuteRequestCoreAsync(
        RequestUri uri,
        HttpMethod method,
        HttpContent content,
        Dictionary<string, string> headers,
        int? graphqlQueryCost,
        CancellationToken cancellationToken = default
    ) => base.ExecuteRequestCoreAsync(uri, method, content, headers, graphqlQueryCost, cancellationToken);
}
