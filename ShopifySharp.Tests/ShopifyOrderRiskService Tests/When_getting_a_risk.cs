using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyOrderRiskService_Tests
{
    [Subject(typeof(OrderRiskService))]
    class When_getting_a_risk
    {
        Establish context = () =>
        {
            OrderId = RiskUtils.GetOrderId().Await().AsTask.Result;
            RiskId = Service.CreateAsync(OrderId, RiskUtils.CreateRisk()).Await().AsTask.Result.Id.Value;
        };

        Because of = () =>
        {
            Risk = Service.GetAsync(OrderId, RiskId).Await().AsTask.Result;
        };

        It should_get_a_risk = () =>
        {
            Risk.ShouldNotBeNull();
            Risk.OrderId.ShouldEqual(OrderId);
            Risk.Message.ShouldEqual(RiskUtils.Message);
            Risk.Score.ShouldEqual(RiskUtils.Score);
            Risk.Recommendation.ShouldEqual(RiskUtils.Recommendation);
            Risk.Source.ShouldEqual(RiskUtils.Source);
            Risk.CauseCancel.ShouldEqual(RiskUtils.CauseCancel);
            Risk.Display.ShouldEqual(RiskUtils.Display);
        };

        Cleanup after = () =>
        {
            if (Risk != null)
            {
                Service.DeleteAsync(OrderId, Risk.Id.Value).Await();
            }
        };

        static long RiskId;

        static long OrderId;

        static OrderRisk Risk;

        static OrderRiskService Service = new OrderRiskService(Utils.MyShopifyUrl, Utils.AccessToken);
    }
}
