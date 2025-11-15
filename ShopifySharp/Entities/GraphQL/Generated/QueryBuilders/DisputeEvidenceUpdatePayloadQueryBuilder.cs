#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class DisputeEvidenceUpdatePayloadQueryBuilder() : GraphQueryBuilder<DisputeEvidenceUpdatePayload>("query disputeEvidenceUpdatePayload")
{
    public DisputeEvidenceUpdatePayloadQueryBuilder AddFieldDisputeEvidence()
    {
        AddField("disputeEvidence");
        return this;
    }

    public DisputeEvidenceUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}