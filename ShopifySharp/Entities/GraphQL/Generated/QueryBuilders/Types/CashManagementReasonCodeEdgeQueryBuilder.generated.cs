#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class CashManagementReasonCodeEdgeQueryBuilder : FieldsQueryBuilderBase<CashManagementReasonCodeEdge, CashManagementReasonCodeEdgeQueryBuilder>
    {
        protected override CashManagementReasonCodeEdgeQueryBuilder Self => this;

        public CashManagementReasonCodeEdgeQueryBuilder() : this("cashManagementReasonCodeEdge")
        {
        }

        public CashManagementReasonCodeEdgeQueryBuilder(string name) : base(new Query<CashManagementReasonCodeEdge>(name))
        {
        }

        public CashManagementReasonCodeEdgeQueryBuilder(IQuery<CashManagementReasonCodeEdge> query) : base(query)
        {
        }

        public CashManagementReasonCodeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CashManagementReasonCodeEdgeQueryBuilder Node(Action<CashManagementReasonCodeUnionCasesBuilder> build)
        {
            var query = new Query<CashManagementReasonCode>("node");
            var unionBuilder = new CashManagementReasonCodeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}