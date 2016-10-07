using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyOrderRiskService_Tests
{
    [Subject(typeof(ShopifyOrderRiskService))]
    class When_creating_a_risk
    {
        Establish context = () =>
        {
            OrderId = RiskUtils.GetOrderId().Await().AsTask.Result;
        };

        Because of = () =>
        {
            Risk = Service.CreateAsync(OrderId, RiskUtils.CreateRisk()).Await().AsTask.Result;
        };

        It should_create_a_risk = () =>
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

        static long OrderId;

        static ShopifyOrderRisk Risk;

        static ShopifyOrderRiskService Service = new ShopifyOrderRiskService(Utils.MyShopifyUrl, Utils.AccessToken);
    }
}
