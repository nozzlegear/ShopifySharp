namespace ShopifySharp;

public enum GraphRequestUserErrorHandling
{
    /// Tells the service to throw an exception if the response contains a <b>non-empty</b> <c>userErrors</c> object.
    Throw,
    /// Tells the service ignore any <c>userErrors</c> objects in the response.
    DoNotThrow
}

