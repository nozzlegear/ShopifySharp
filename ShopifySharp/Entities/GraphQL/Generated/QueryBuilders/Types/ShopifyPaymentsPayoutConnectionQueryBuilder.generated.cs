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

        public ShopifyPaymentsPayoutConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutEdgeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayoutEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsPayoutEdge>(query);
            return this;
        }

        public ShopifyPaymentsPayoutConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsPayout>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyPaymentsPayoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsPayout>(query);
            return this;
        }

        public ShopifyPaymentsPayoutConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}