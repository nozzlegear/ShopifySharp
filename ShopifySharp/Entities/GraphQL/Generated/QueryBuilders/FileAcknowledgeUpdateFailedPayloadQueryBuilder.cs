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

public class FileAcknowledgeUpdateFailedPayloadQueryBuilder() : GraphQueryBuilder<FileAcknowledgeUpdateFailedPayload>("query fileAcknowledgeUpdateFailedPayload")
{
    public FileAcknowledgeUpdateFailedPayloadQueryBuilder AddFieldFiles()
    {
        AddField("files");
        return this;
    }

    public FileAcknowledgeUpdateFailedPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}