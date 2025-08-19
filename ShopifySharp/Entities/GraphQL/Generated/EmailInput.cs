#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for an email.
/// </summary>
public record EmailInput : GraphQLInputObject<EmailInput>
{
    /// <summary>
    /// Specifies any bcc recipients for the email.
    /// </summary>
    [JsonPropertyName("bcc")]
    public ICollection<string>? bcc { get; set; } = null;

    /// <summary>
    /// Specifies the email body.
    /// </summary>
    [JsonPropertyName("body")]
    public string? body { get; set; } = null;

    /// <summary>
    /// Specifies a custom message to include in the email.
    /// </summary>
    [JsonPropertyName("customMessage")]
    public string? customMessage { get; set; } = null;

    /// <summary>
    /// Specifies the email sender.
    /// </summary>
    [JsonPropertyName("from")]
    public string? @from { get; set; } = null;

    /// <summary>
    /// Specifies the email subject.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? subject { get; set; } = null;

    /// <summary>
    /// Specifies the email recipient.
    /// </summary>
    [JsonPropertyName("to")]
    public string? to { get; set; } = null;
}