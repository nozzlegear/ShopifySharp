using Machine.Specifications;

namespace ShopifySharp.Tests.ShopifyApplicationCreditService_Tests
{
    [Subject(typeof(ShopifyApplicationCreditService))]
    class When_creating_an_application_credit
    {
        Establish context = () =>
        {
            
        };

        Because of = () =>
        {
            Credit = AppCreditUtils.Service.CreateAsync(AppCreditUtils.CreateCredit()).Await();
        };

        [Ignore("Application Credits cannot be tested because they're unusable in a private application.")]
        It should_create_an_application_credit = () =>
        {
            Credit.ShouldNotBeNull();
            Credit.Id.HasValue.ShouldBeTrue();
            Credit.Description.ShouldNotBeEmpty();
            Credit.Test.Value.ShouldBeTrue();
            Credit.Amount.ShouldBeGreaterThan(0);
        };

        Cleanup after = () =>
        {

        };
        
        static ShopifyApplicationCredit Credit;
    }
}
