#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ShopifyPaymentsBalanceTransactionEdgeQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsBalanceTransactionEdge, ShopifyPaymentsBalanceTransactionEdgeQueryBuilder>
    {
        protected override ShopifyPaymentsBalanceTransactionEdgeQueryBuilder Self => this;

        public ShopifyPaymentsBalanceTransactionEdgeQueryBuilder() : this("shopifyPaymentsBalanceTransactionEdge")
        {
        }

        public ShopifyPaymentsBalanceTransactionEdgeQueryBuilder(string name) : base(new Query<ShopifyPaymentsBalanceTransactionEdge>(name))
        {
        }

        public ShopifyPaymentsBalanceTransactionEdgeQueryBuilder(IQuery<ShopifyPaymentsBalanceTransactionEdge> query) : base(query)
        {
        }

        public ShopifyPaymentsBalanceTransactionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ShopifyPaymentsBalanceTransactionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsBalanceTransaction>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsBalanceTransaction>(query);
            return this;
        }
    }
}