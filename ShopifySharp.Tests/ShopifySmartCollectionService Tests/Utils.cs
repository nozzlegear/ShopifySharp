namespace ShopifySharp.Tests.ShopifySmartCollectionService_Tests
{
    static class SmartCollectionUtils
    {
        public static string BodyHtml { get; } = "<h1>Hello world!</h1>";

        public static string Handle { get; } = "ShopifySharp-Handle";

        public static string Title { get; } = "ShopifySharp Test Smart Collection";

        public static ShopifySmartCollection CreateCollection()
        {
            return new ShopifySmartCollection()
            {
                BodyHtml = BodyHtml,
                Handle = Handle,
                Title = Title,
            };
        }
    }
}
