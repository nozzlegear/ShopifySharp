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
/// Represents information about the store credit accounts associated to the specified owner.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "__typename")]
[JsonDerivedType(typeof(CompanyLocation), typeDiscriminator: "CompanyLocation")]
[JsonDerivedType(typeof(Customer), typeDiscriminator: "Customer")]
public interface IHasStoreCreditAccounts : IGraphQLObject
{
    /// <summary>
    /// Returns a list of store credit accounts that belong to the owner resource.
    /// A store credit account owner can hold multiple accounts each with a different currency.
    /// </summary>
    [JsonPropertyName("storeCreditAccounts")]
    public StoreCreditAccountConnection? storeCreditAccounts { get; set; }
}