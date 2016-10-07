using Machine.Specifications;
using System;

namespace ShopifySharp.Tests.ShopifyOrderRiskService_Tests
{
    [Subject(typeof(ShopifyOrderRiskService))]
    class When_deleting_a_risk
    {
        Establish context = () =>
        {
            OrderId = RiskUtils.GetOrderId().Await().AsTask.Result;
            RiskId = Service.CreateAsync(OrderId, RiskUtils.CreateRisk()).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            Ex = Catch.Exception(() => Service.DeleteAsync(OrderId, RiskId).Await());
        };

        It should_delete_a_risk = () =>
        {
            Ex.ShouldBeNull();
        };

        Cleanup after = () =>
        {
        };

        static long OrderId;

        static long RiskId;

        static Exception Ex;

        static ShopifyOrderRiskService Service = new ShopifyOrderRiskService(Utils.MyShopifyUrl, Utils.AccessToken);
    }
}
