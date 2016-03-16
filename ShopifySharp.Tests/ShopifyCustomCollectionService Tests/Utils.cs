namespace ShopifySharp.Tests.ShopifyCustomCollectionService_Tests
{
    public static class SubjectUtils
    {
        public static ShopifyCustomCollection CreateValidObject()
        {
            var output = new ShopifyCustomCollection()
            {
                Title = "Things",
                Published = false,
                Image = new ShopifyCustomCollectionImage()
                {
                    Src = "http://placehold.it/250x250"
                }
            };

            return output;
        }
    }
}
