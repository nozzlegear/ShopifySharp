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

public class CompanyConnectionQueryBuilder() : GraphQueryBuilder<CompanyConnection>("companyConnection")
{
    public CompanyConnectionQueryBuilder AddFieldEdges(Func<CompanyEdgeQueryBuilder, CompanyEdgeQueryBuilder> build)
    {
        AddField<CompanyEdge, CompanyEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CompanyConnectionQueryBuilder AddFieldNodes(Func<CompanyQueryBuilder, CompanyQueryBuilder> build)
    {
        AddField<Company, CompanyQueryBuilder>("nodes", build);
        return this;
    }

    public CompanyConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}