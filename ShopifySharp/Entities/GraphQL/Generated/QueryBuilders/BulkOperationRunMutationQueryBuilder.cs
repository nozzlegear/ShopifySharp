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

public class BulkOperationRunMutationQueryBuilder() : GraphQueryBuilder<BulkOperationRunMutationPayload>("query bulkOperationRunMutation")
{
    public BulkOperationRunMutationQueryBuilder AddArgumentClientIdentifier(string? clientIdentifier)
    {
        AddArgument("clientIdentifier", clientIdentifier);
        return this;
    }

    public BulkOperationRunMutationQueryBuilder AddArgumentGroupObjects(bool? groupObjects)
    {
        AddArgument("groupObjects", groupObjects);
        return this;
    }

    public BulkOperationRunMutationQueryBuilder AddArgumentMutation(string? mutation)
    {
        AddArgument("mutation", mutation);
        return this;
    }

    public BulkOperationRunMutationQueryBuilder AddArgumentStagedUploadPath(string? stagedUploadPath)
    {
        AddArgument("stagedUploadPath", stagedUploadPath);
        return this;
    }
}