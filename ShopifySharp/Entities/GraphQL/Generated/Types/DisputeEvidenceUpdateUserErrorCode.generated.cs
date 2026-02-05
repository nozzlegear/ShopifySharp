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
/// Possible error codes that can be returned by `DisputeEvidenceUpdateUserError`.
/// </summary>
public enum DisputeEvidenceUpdateUserErrorCode
{
    DISPUTE_EVIDENCE_NOT_FOUND,
    EVIDENCE_ALREADY_ACCEPTED,
    EVIDENCE_PAST_DUE_DATE,
    FILES_SIZE_EXCEEDED_LIMIT,
    FILE_NOT_FOUND,
    TOO_LARGE,
    INVALID,
}