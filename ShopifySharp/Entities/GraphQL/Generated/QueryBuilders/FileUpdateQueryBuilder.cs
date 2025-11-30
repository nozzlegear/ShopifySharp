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

public class FileUpdateQueryBuilder() : GraphQueryBuilder<FileUpdatePayload>("query fileUpdate")
{
    public FileUpdateQueryBuilder AddArgumentFiles(ICollection<FileUpdateInput>? files)
    {
        AddArgument("files", files);
        return this;
    }
}