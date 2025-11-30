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

public class IJobResultQueryBuilder() : GraphQueryBuilder<IJobResult>("query iJobResult")
{
    public IJobResultQueryBuilder AddFieldDone()
    {
        AddField("done");
        return this;
    }

    public IJobResultQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }
}