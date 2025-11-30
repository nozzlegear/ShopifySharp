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

public class UTMParametersQueryBuilder() : GraphQueryBuilder<UTMParameters>("query uTMParameters")
{
    public UTMParametersQueryBuilder AddFieldCampaign()
    {
        AddField("campaign");
        return this;
    }

    public UTMParametersQueryBuilder AddFieldContent()
    {
        AddField("content");
        return this;
    }

    public UTMParametersQueryBuilder AddFieldMedium()
    {
        AddField("medium");
        return this;
    }

    public UTMParametersQueryBuilder AddFieldSource()
    {
        AddField("source");
        return this;
    }

    public UTMParametersQueryBuilder AddFieldTerm()
    {
        AddField("term");
        return this;
    }
}