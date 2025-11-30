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

public class CompanyContactConnectionQueryBuilder() : GraphQueryBuilder<CompanyContactConnection>("companyContactConnection")
{
    public CompanyContactConnectionQueryBuilder AddFieldEdges(Func<CompanyContactEdgeQueryBuilder, CompanyContactEdgeQueryBuilder> build)
    {
        AddField<CompanyContactEdge, CompanyContactEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CompanyContactConnectionQueryBuilder AddFieldNodes(Func<CompanyContactQueryBuilder, CompanyContactQueryBuilder> build)
    {
        AddField<CompanyContact, CompanyContactQueryBuilder>("nodes", build);
        return this;
    }

    public CompanyContactConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}