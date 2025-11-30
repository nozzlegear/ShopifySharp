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

public class CompanyLocationConnectionQueryBuilder() : GraphQueryBuilder<CompanyLocationConnection>("companyLocationConnection")
{
    public CompanyLocationConnectionQueryBuilder AddFieldEdges(Func<CompanyLocationEdgeQueryBuilder, CompanyLocationEdgeQueryBuilder> build)
    {
        AddField<CompanyLocationEdge, CompanyLocationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CompanyLocationConnectionQueryBuilder AddFieldNodes(Func<CompanyLocationQueryBuilder, CompanyLocationQueryBuilder> build)
    {
        AddField<CompanyLocation, CompanyLocationQueryBuilder>("nodes", build);
        return this;
    }

    public CompanyLocationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}