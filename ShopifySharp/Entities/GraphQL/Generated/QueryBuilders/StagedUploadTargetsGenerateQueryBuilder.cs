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
public class StagedUploadTargetsGenerateQueryBuilder() : GraphQueryBuilder<StagedUploadTargetsGeneratePayload>("query stagedUploadTargetsGenerate")
{
    public StagedUploadTargetsGenerateQueryBuilder AddArgumentInput(ICollection<StageImageInput>? input)
    {
        AddArgument("input", input);
        return this;
    }
}