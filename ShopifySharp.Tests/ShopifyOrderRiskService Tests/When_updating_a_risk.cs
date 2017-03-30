using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyOrderRiskService_Tests
{
    [Subject(typeof(OrderRiskService))]
    class When_updating_a_risk
    {
        Establish context = () =>
        {
            OrderId = RiskUtils.GetOrderId().Await().AsTask.Result;
            Risk = Service.CreateAsync(OrderId, RiskUtils.CreateRisk()).Await().AsTask.Result;
        };

        Because of = () =>
        {
            Risk.Message = UpdatedMessage;
            Risk = Service.UpdateAsync(OrderId, Risk).Await().AsTask.Result;
        };

        It should_update_a_risk = () =>
        {
            Risk.Message.ShouldEqual(UpdatedMessage);
        };

        Cleanup after = () =>
        {
            if (Risk != null)
            {
                Service.DeleteAsync(OrderId, Risk.Id.Value).Await();
            }
        };

        static long OrderId;

        static OrderRisk Risk;

        static string UpdatedMessage = "An updated risk message.";

        static OrderRiskService Service = new OrderRiskService(Utils.MyShopifyUrl, Utils.AccessToken);
    }
}
