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

public class FileErrorQueryBuilder() : GraphQueryBuilder<FileError>("query fileError")
{
    public FileErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public FileErrorQueryBuilder AddFieldDetails()
    {
        AddField("details");
        return this;
    }

    public FileErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}