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

public class IFileQueryBuilder() : GraphQueryBuilder<IFile>("query iFile")
{
    public IFileQueryBuilder AddFieldAlt()
    {
        AddField("alt");
        return this;
    }

    public IFileQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public IFileQueryBuilder AddFieldFileErrors()
    {
        AddField("fileErrors");
        return this;
    }

    public IFileQueryBuilder AddFieldFileStatus()
    {
        AddField("fileStatus");
        return this;
    }

    public IFileQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public IFileQueryBuilder AddFieldPreview()
    {
        AddField("preview");
        return this;
    }

    public IFileQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}