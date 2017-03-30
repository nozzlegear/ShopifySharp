namespace ShopifySharp.Tests.ShopifyCustomCollectionService_Tests
{
    public static class SubjectUtils
    {
        public static CustomCollection CreateValidObject()
        {
            var output = new CustomCollection()
            {
                Title = "Things",
                Published = false,
                Image = new CustomCollectionImage()
                {
                    Src = "http://placehold.it/250x250"
                }
            };

            return output;
        }
    }
}
