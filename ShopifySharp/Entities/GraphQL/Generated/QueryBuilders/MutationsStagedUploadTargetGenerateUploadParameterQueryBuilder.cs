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

public class MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder() : GraphQueryBuilder<MutationsStagedUploadTargetGenerateUploadParameter>("query mutationsStagedUploadTargetGenerateUploadParameter")
{
    public MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}