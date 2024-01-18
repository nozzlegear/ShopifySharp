using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "ExecuteRequestCancellation"), Trait("Category", "DotNetFramework"), Collection("DotNetFramework tests")]
public class ExecuteRequestCancellation_Tests
{
    private class TestService : ShopifyService
    {
        // Use Shopify's mock.shop API as an API endpoint which doesn't require an access token.
        private const string MyShopifyDomain = "https://mock.shop";

        /// Number of seconds to delay before sending request to the mock.shop API. This is only used to ensure the
        /// cancellationToken is canceled before the request is actually made.
        private readonly TimeSpan _delay = TimeSpan.FromSeconds(1);
            
        public TestService() : base(MyShopifyDomain, "fake-token")
        {
        }
            
        // These are what services call to execute their public API requests
        public Task<T> ExecuteGetAsync<T>(string path, string resultRootElt, string fields, CancellationToken cancellationToken = default)
        {
            Thread.Sleep(_delay);
            return base.ExecuteGetAsync<T>(path, resultRootElt, fields, cancellationToken);
        }

        public Task<T> ExecuteGetAsync<T>(string path, string resultRootElt, Parameterizable queryParams = null, CancellationToken cancellationToken = default)
        {
            Thread.Sleep(_delay);
            return base.ExecuteGetAsync<T>(path, resultRootElt, queryParams, cancellationToken);
        }

        public Task<ListResult<T>> ExecuteGetListAsync<T>(string path, string resultRootElt, ListFilter<T> filter, CancellationToken cancellationToken = default)
        {
            Thread.Sleep(_delay);
            return base.ExecuteGetListAsync(path, resultRootElt, filter, cancellationToken);
        }
            
        public Task<T> ExecutePostAsync<T>(string path, string resultRootElt, object jsonContent = null, CancellationToken cancellationToken = default)
        {
            Thread.Sleep(_delay);
            return base.ExecutePostAsync<T>(path, resultRootElt, cancellationToken, jsonContent);
        }

        public Task<T> ExecutePutAsync<T>(string path, string resultRootElt, object jsonContent = null, CancellationToken cancellationToken = default)
        {
            Thread.Sleep(_delay);
            return base.ExecutePutAsync<T>(path, resultRootElt, cancellationToken, jsonContent);
        }

        public new Task ExecuteDeleteAsync(string path, CancellationToken cancellationToken)
        {
            Thread.Sleep(_delay);
            return base.ExecuteDeleteAsync(path, cancellationToken);
        }

        public Task<RequestResult<JToken>> ExecuteRequestAsync(RequestUri uri, HttpMethod method, HttpContent content = null, CancellationToken cancellationToken = default)
        {
            Thread.Sleep(_delay);
            return base.ExecuteRequestAsync(uri, method, cancellationToken, content);
        }
    }

    [Fact]
    public async Task Cancelling_An_ExecuteGetListAsync_Terminates_HttpRequest()
    {
        var service = new TestService();
        var cts = new CancellationTokenSource();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(async () =>
        {
            var task = service.ExecuteGetListAsync<object>(string.Empty, string.Empty, null, cts.Token);

            cts.Cancel();

            await task;
        });
    }

    [Fact]
    public async Task Cancelling_An_ExecuteGetAsync_Terminates_HttpRequest()
    {
        var service = new TestService();
        var cts = new CancellationTokenSource();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(async () =>
        {
            var task = service.ExecuteGetAsync<object>(string.Empty, string.Empty, string.Empty, cts.Token);

            cts.Cancel();

            await task;
        });
    }
                
    [Fact]
    public async Task Cancelling_An_ExecuteGetAsyncFilter_Terminates_HttpRequest()
    {
        var service = new TestService();
        var cts = new CancellationTokenSource();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(async () =>
        {
            var task = service.ExecuteGetAsync<object>(string.Empty, string.Empty, new PageCountFilter(), cts.Token);

            cts.Cancel();

            await task;
        });
    }
                        
    [Fact]
    public async Task Cancelling_An_ExecutePutAsync_Terminates_HttpRequest()
    {
        var service = new TestService();
        var cts = new CancellationTokenSource();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(async () =>
        {
            var task = service.ExecutePutAsync<object>(string.Empty, string.Empty, null, cts.Token);

            cts.Cancel();

            await task;
        });
    }
                                
    [Fact]
    public async Task Cancelling_An_ExecutePostAsync_Terminates_HttpRequest()
    {
        var service = new TestService();
        var cts = new CancellationTokenSource();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(async () =>
        {
            var task = service.ExecutePostAsync<object>(string.Empty, string.Empty, null, cts.Token);

            cts.Cancel();

            await task;
        });
    }
                                
    [Fact]
    public async Task Cancelling_An_ExecuteDeleteAsync_Terminates_HttpRequest()
    {
        var service = new TestService();
        var cts = new CancellationTokenSource();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(async () =>
        {
            var task = service.ExecuteDeleteAsync(string.Empty, cts.Token);

            cts.Cancel();

            await task;
        });
    }

    [Fact]
    public async Task Cancelling_An_ExecuteRequestAsync_Terminates_HttpRequest()
    {
        var service = new TestService();
        var cts = new CancellationTokenSource();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(async () =>
        {
            var task = service.ExecuteRequestAsync(new RequestUri(new Uri("http://unreachable")), HttpMethod.Get, null, cts.Token);

            cts.Cancel();

            await task;
        });
    }
        
    private static OrderService OrderService => new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);

    [Fact]
    public async Task Cancelling_An_OrderService_List_Terminates_HttpRequest()
    {
        var cts = new CancellationTokenSource();

        await Assert.ThrowsAnyAsync<OperationCanceledException>(async () =>
        {
            var task = OrderService.ListAsync(cancellationToken: cts.Token);

            cts.Cancel();

            await task;
        });
    }
}