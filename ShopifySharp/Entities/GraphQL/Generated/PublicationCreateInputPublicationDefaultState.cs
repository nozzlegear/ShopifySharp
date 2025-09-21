#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the possible values for the default state of a publication.
/// </summary>
public enum PublicationCreateInputPublicationDefaultState
{
    EMPTY,
    ALL_PRODUCTS,
}