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

public class Model3dBoundingBoxQueryBuilder() : GraphQueryBuilder<Model3dBoundingBox>("model3dBoundingBox")
{
    public Model3dBoundingBoxQueryBuilder AddFieldSize(Func<Vector3QueryBuilder, Vector3QueryBuilder> build)
    {
        AddField<Vector3, Vector3QueryBuilder>("size", build);
        return this;
    }
}