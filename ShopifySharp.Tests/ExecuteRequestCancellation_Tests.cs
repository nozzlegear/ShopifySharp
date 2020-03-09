using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "ExecuteRequestCancellation")]
    public class ExecuteRequestCancellation_Tests
    {

        public class TestService : ShopifyService
        {
            public TestService() : base("someurl", "sometoken")
            {
            }
            
            // these are what services call to execute their public API requests
            public new Task<T> ExecuteGetAsync<T>(string path, string resultRootElt, string fields, CancellationToken cancellationToken = default)
            {
                return base.ExecuteGetAsync<T>(path, resultRootElt, fields, cancellationToken);
            }

            public new Task<T> ExecuteGetAsync<T>(string path, string resultRootElt, Parameterizable queryParams = null, CancellationToken cancellationToken = default)
            {
                return base.ExecuteGetAsync<T>(path, resultRootElt, queryParams, cancellationToken);
            }

            public new Task<ListResult<T>> ExecuteGetListAsync<T>(string path, string resultRootElt, ListFilter<T> filter, CancellationToken cancellationToken = default)
            {
                return base.ExecuteGetListAsync(path, resultRootElt, filter, cancellationToken);
            }
            
            public new Task<T> ExecutePostAsync<T>(string path, string resultRootElt, object jsonContent = null, CancellationToken cancellationToken = default)
            {
                return base.ExecutePostAsync<T>(path, resultRootElt, jsonContent, cancellationToken);
            }

            public new Task<T> ExecutePutAsync<T>(string path, string resultRootElt, object jsonContent = null, CancellationToken cancellationToken = default)
            {
                return base.ExecutePutAsync<T>(path, resultRootElt, jsonContent, cancellationToken);
            }

            public new Task ExecuteDeleteAsync(string path, CancellationToken cancellationToken)
            {
                return base.ExecuteDeleteAsync(path, cancellationToken);
            }

            public new Task<RequestResult<JToken>> ExecuteRequestAsync(RequestUri uri, HttpMethod method, HttpContent content = null, CancellationToken cancellationToken = default)
            {
                return base.ExecuteRequestAsync(uri, method, content, cancellationToken);
            }
        }

        [Fact]
        public async Task Cancelling_An_ExecuteGetListAsync_Terminates_HttpRequest()
        {
            var service = new TestService();
            var cts = new CancellationTokenSource();

            await Assert.ThrowsAsync<TaskCanceledException>(async () =>
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

            await Assert.ThrowsAsync<TaskCanceledException>(async () =>
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

            await Assert.ThrowsAsync<TaskCanceledException>(async () =>
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

            await Assert.ThrowsAsync<TaskCanceledException>(async () =>
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

            await Assert.ThrowsAsync<TaskCanceledException>(async () =>
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

            await Assert.ThrowsAsync<TaskCanceledException>(async () =>
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

            await Assert.ThrowsAsync<TaskCanceledException>(async () =>
            {
                var task = service.ExecuteRequestAsync(new RequestUri(new Uri("http://unreachable")), HttpMethod.Get, null, cts.Token);

                cts.Cancel();

                await task;
            });
        }
        
        private OrderService OrderService { get; } = new OrderService(Utils.MyShopifyUrl, Utils.AccessToken);

        [Fact]
        public async Task Cancelling_An_OrderService_List_Terminates_HttpRequest()
        {
            var cts = new CancellationTokenSource();

            await Assert.ThrowsAsync<TaskCanceledException>(async () =>
            {
                var task = OrderService.ListAsync(cancellationToken: cts.Token);

                cts.Cancel();

                await task;
            });
        }
    }
}
