#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The supported subject types of deletion events.
/// </summary>
public enum DeletionEventSubjectType
{
    COLLECTION,
    PRODUCT,
}