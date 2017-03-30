using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyApplicationCreditService_Tests
{
    [Subject(typeof(ShopifyApplicationCreditService))]
    class When_getting_an_application_credit
    {
        Establish context = () =>
        {
            //CreatedId = AppCreditUtils.Service.CreateAsync(AppCreditUtils.CreateCredit()).Await().AsTask.Result.Id;
        };

        Because of = () =>
        {
            //Credit = AppCreditUtils.Service.GetAsync(CreatedId.Value).Await();
        };
        
        [Ignore("Application Credits cannot be tested because they're unusable in a private application.")]
        It should_get_an_application_credit = () =>
        {
            Credit.ShouldNotBeNull();
            Credit.Id.Value.ShouldEqual(CreatedId.Value);
            Credit.Description.ShouldNotBeEmpty();
            Credit.Test.Value.ShouldBeTrue();
            Credit.Amount.ShouldBeGreaterThan(0);
        };

        Cleanup after = () =>
        {
            
        };

        static long? CreatedId;

        static ApplicationCredit Credit;
    }
}
