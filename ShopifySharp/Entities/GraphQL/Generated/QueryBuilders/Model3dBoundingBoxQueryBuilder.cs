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

public class Model3dBoundingBoxQueryBuilder() : GraphQueryBuilder<Model3dBoundingBox>("query model3dBoundingBox")
{
    public Model3dBoundingBoxQueryBuilder AddFieldSize()
    {
        AddField("size");
        return this;
    }
}