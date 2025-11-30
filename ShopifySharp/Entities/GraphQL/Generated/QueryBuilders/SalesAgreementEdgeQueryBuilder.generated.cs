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

public class SalesAgreementEdgeQueryBuilder() : GraphQueryBuilder<SalesAgreementEdge>("salesAgreementEdge")
{
    public SalesAgreementEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SalesAgreementEdgeQueryBuilder AddFieldNode(Func<SalesAgreementQueryBuilder, SalesAgreementQueryBuilder> build)
    {
        AddField<ISalesAgreement, SalesAgreementQueryBuilder>("node", build);
        return this;
    }
}