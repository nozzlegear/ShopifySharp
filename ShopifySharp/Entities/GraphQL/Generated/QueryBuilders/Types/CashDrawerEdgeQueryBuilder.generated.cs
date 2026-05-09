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
    public sealed class CashDrawerEdgeQueryBuilder : FieldsQueryBuilderBase<CashDrawerEdge, CashDrawerEdgeQueryBuilder>
    {
        protected override CashDrawerEdgeQueryBuilder Self => this;

        public CashDrawerEdgeQueryBuilder() : this("cashDrawerEdge")
        {
        }

        public CashDrawerEdgeQueryBuilder(string name) : base(new Query<CashDrawerEdge>(name))
        {
        }

        public CashDrawerEdgeQueryBuilder(IQuery<CashDrawerEdge> query) : base(query)
        {
        }

        public CashDrawerEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CashDrawerEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder> build)
        {
            var query = new Query<CashDrawer>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CashDrawerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CashDrawer>(query);
            return this;
        }
    }
}