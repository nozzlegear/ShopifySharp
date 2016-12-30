using Machine.Specifications;
using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Tests.ShopifyException_Tests
{
    [Subject(typeof(ShopifyRateLimitException))]
    class When_reaching_the_rate_limit_with_smart_retry_policy
    {
        Establish context = () =>
        {
            RequestEngine.SetExecutionPolicy(new SmartRetryExecutionPolicy());
        };

        Because of = () =>
        {
            try
            {
                // Reach the rate limit of 40 requests per second
                var tasks = Enumerable.Range(0, 45)
                                      .Select(_ => Service.ListAsync(new ShopifyEventListFilter { Limit = 1 }));
                Results = Task.WhenAll(tasks).Await().AsTask.Result;
            }
            catch (Exception e)
            {
                Ex = e;
            }
        };

        It should_not_throw_a_rate_limit_exception = () =>
        {
            Ex.ShouldBeNull();
            Results.Count().ShouldEqual(45);
        };

        Cleanup after = () =>
        {
        };

        static ShopifyEventService Service = new ShopifyEventService(Utils.MyShopifyUrl, Utils.AccessToken);
        static Exception Ex;
        static IEnumerable<ShopifyEvent>[] Results;
    }
}
