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

public class DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder() : GraphQueryBuilder<DiscountRedeemCodeBulkCreationCodeConnection>("discountRedeemCodeBulkCreationCodeConnection")
{
    public DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder AddFieldEdges(Func<DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder, DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder> build)
    {
        AddField<DiscountRedeemCodeBulkCreationCodeEdge, DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder AddFieldNodes(Func<DiscountRedeemCodeBulkCreationCodeQueryBuilder, DiscountRedeemCodeBulkCreationCodeQueryBuilder> build)
    {
        AddField<DiscountRedeemCodeBulkCreationCode, DiscountRedeemCodeBulkCreationCodeQueryBuilder>("nodes", build);
        return this;
    }

    public DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}