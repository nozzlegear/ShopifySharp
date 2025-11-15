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

[Obsolete("Use `stagedUploadsCreate` instead.")]
public class StagedUploadTargetGenerateQueryBuilder() : GraphQueryBuilder<StagedUploadTargetGeneratePayload>("query stagedUploadTargetGenerate")
{
    public StagedUploadTargetGenerateQueryBuilder AddArgumentInput(StagedUploadTargetGenerateInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}