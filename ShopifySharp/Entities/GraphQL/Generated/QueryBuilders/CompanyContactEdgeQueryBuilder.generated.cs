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

public class CompanyContactEdgeQueryBuilder() : GraphQueryBuilder<CompanyContactEdge>("companyContactEdge")
{
    public CompanyContactEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CompanyContactEdgeQueryBuilder AddFieldNode(Func<CompanyContactQueryBuilder, CompanyContactQueryBuilder> build)
    {
        AddField<CompanyContact, CompanyContactQueryBuilder>("node", build);
        return this;
    }
}