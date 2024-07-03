#nullable enable
using System;

namespace ShopifySharp;

public class ShopifyException(string message, Exception? innerException = null) : Exception(message, innerException);
