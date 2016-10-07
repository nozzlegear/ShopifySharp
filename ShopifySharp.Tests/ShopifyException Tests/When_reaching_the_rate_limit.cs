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
    class When_reaching_the_rate_limit
    {
        Establish context = () =>
        {

        };

        Because of = () =>
        {
            try
            {
                throw new ShopifyRateLimitException();
            }
            catch (ShopifyException e)
            {
                CaughtRateExceptionWithBaseException = true;
            }

            var tasks = new List<Task<IEnumerable<ShopifyEvent>>>();

            // Reach the rate limit of 40 requests per second
            for (int i = 0; i < 100; i++)
            {
                tasks.Add(Service.ListAsync(new ShopifyEventListFilter()
                {
                    Limit = 1,
                }));
            }

            try
            {
                var result = Task.WhenAll(tasks.ToArray()).Await().AsTask.Result;
            }
            catch (AggregateException e)
            {
                Ex = e.InnerException;
            }
            catch (Exception e)
            {
                Ex = e;
            }
        };

        It should_throw_a_rate_limit_exception = () =>
        {
            CaughtRateExceptionWithBaseException.ShouldBeTrue();
            Ex.ShouldBeOfExactType<ShopifyRateLimitException>();

            var e = (ShopifyException)Ex;

            e.JsonError.ShouldNotBeNull();
            e.Errors.Count.ShouldBeGreaterThanOrEqualTo(1);
            e.Errors.First().Key.Equals("Error").ShouldBeTrue();
            e.Errors.First().Value.First().ShouldEqual("Exceeded 2 calls per second for api client. Reduce request rates to resume uninterrupted service.");
        };

        Cleanup after = () =>
        {

        };

        static ShopifyEventService Service = new ShopifyEventService(Utils.MyShopifyUrl, Utils.AccessToken);

        static Exception Ex;

        static bool CaughtRateExceptionWithBaseException = false;
    }
}
