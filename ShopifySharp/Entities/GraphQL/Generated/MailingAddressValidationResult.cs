#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Highest level of validation concerns identified for the address.
/// </summary>
public enum MailingAddressValidationResult
{
    NO_ISSUES,
    ERROR,
    WARNING,
}