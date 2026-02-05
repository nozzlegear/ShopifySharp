#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Highest level of validation concerns identified for the address.
/// </summary>
public enum MailingAddressValidationResult
{
    NO_ISSUES,
    ERROR,
    WARNING,
}