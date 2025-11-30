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

public class Model3dSourceQueryBuilder() : GraphQueryBuilder<Model3dSource>("model3dSource")
{
    public Model3dSourceQueryBuilder AddFieldFilesize()
    {
        AddField("filesize");
        return this;
    }

    public Model3dSourceQueryBuilder AddFieldFormat()
    {
        AddField("format");
        return this;
    }

    public Model3dSourceQueryBuilder AddFieldMimeType()
    {
        AddField("mimeType");
        return this;
    }

    public Model3dSourceQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}