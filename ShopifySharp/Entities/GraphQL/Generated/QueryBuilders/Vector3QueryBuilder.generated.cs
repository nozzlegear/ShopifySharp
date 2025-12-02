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

public class Vector3QueryBuilder() : GraphQueryBuilder<Vector3>("vector3")
{
    public Vector3QueryBuilder AddFieldX()
    {
        AddField("x");
        return this;
    }

    public Vector3QueryBuilder AddFieldY()
    {
        AddField("y");
        return this;
    }

    public Vector3QueryBuilder AddFieldZ()
    {
        AddField("z");
        return this;
    }
}