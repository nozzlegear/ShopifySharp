#nullable enable
using System;

namespace ShopifySharp;

/// <summary>
/// Thrown when a refresh token is expired or otherwise invalid for performing a token refresh operation.
/// </summary>
[Serializable]
public class ShopifyInvalidRefreshTokenException(string message, Exception? innerException = null)
    : ShopifyException(message, innerException);
