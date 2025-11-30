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

public class FileCreatePayloadQueryBuilder() : GraphQueryBuilder<FileCreatePayload>("query fileCreatePayload")
{
    public FileCreatePayloadQueryBuilder AddFieldFiles()
    {
        AddField("files");
        return this;
    }

    public FileCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}