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

public class FileUpdatePayloadQueryBuilder() : GraphQueryBuilder<FileUpdatePayload>("query fileUpdatePayload")
{
    public FileUpdatePayloadQueryBuilder AddFieldFiles()
    {
        AddField("files");
        return this;
    }

    public FileUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}