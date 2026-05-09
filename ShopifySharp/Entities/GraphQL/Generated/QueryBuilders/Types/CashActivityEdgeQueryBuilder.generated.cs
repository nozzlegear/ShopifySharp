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
    public sealed class CashActivityEdgeQueryBuilder : FieldsQueryBuilderBase<CashActivityEdge, CashActivityEdgeQueryBuilder>
    {
        protected override CashActivityEdgeQueryBuilder Self => this;

        public CashActivityEdgeQueryBuilder() : this("cashActivityEdge")
        {
        }

        public CashActivityEdgeQueryBuilder(string name) : base(new Query<CashActivityEdge>(name))
        {
        }

        public CashActivityEdgeQueryBuilder(IQuery<CashActivityEdge> query) : base(query)
        {
        }

        public CashActivityEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CashActivityEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityQueryBuilder> build)
        {
            var query = new Query<ICashActivity>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ICashActivity>(query);
            return this;
        }
    }
}