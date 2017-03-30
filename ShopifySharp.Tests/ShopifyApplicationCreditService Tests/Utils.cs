namespace ShopifySharp.Tests.ShopifyApplicationCreditService_Tests
{
    static class AppCreditUtils
    {
        public static ApplicationCreditService Service = new ApplicationCreditService(Utils.MyShopifyUrl, Utils.AccessToken);

        public static ApplicationCredit CreateCredit()
        {
            return new ApplicationCredit()
            {
                Description = "Refund for Foo",
                Amount = 10.00m,
                Test = true,
            };
        }
    }
}
