#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class StagedUploadParameterQueryBuilder() : GraphQueryBuilder<StagedUploadParameter>("stagedUploadParameter")
{
    public StagedUploadParameterQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public StagedUploadParameterQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}