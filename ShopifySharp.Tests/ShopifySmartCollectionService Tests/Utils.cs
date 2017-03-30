namespace ShopifySharp.Tests.ShopifySmartCollectionService_Tests
{
    static class SmartCollectionUtils
    {
        public static string BodyHtml { get; } = "<h1>Hello world!</h1>";

        public static string Handle { get; } = "ShopifySharp-Handle";

        public static string Title { get; } = "ShopifySharp Test Smart Collection";

        public static SmartCollection CreateCollection()
        {
            return new SmartCollection()
            {
                BodyHtml = BodyHtml,
                Handle = Handle,
                Title = Title,
            };
        }
    }
}
