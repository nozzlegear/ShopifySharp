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
    public sealed class ShopifyPaymentsPayoutConnectionQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsPayoutConnection, ShopifyPaymentsPayoutConnectionQueryBuilder>
    {
        protected override ShopifyPaymentsPayoutConnectionQueryBuilder Self => this;

        public ShopifyPaymentsPayoutConnectionQueryBuilder() : this("shopifyPaymentsPayoutConnection")
        {
        }

        public ShopifyPaymentsPayoutConnectionQueryBuilder(string name) : base(new Query<ShopifyPaymentsPayoutConnection>(name))
        {
        }

        public ShopifyPaymentsPayoutConnectionQueryBuilder(IQuery<ShopifyPaymentsPayoutConnection> query) : base(query)
        {
        }

        public ShopifyPaymentsPayoutConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsPayoutEdgeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayoutEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsPayoutEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsPayoutEdge>(query);
            return this;
        }

        public ShopifyPaymentsPayoutConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsPayoutQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayout>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsPayoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsPayout>(query);
            return this;
        }

        public ShopifyPaymentsPayoutConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}