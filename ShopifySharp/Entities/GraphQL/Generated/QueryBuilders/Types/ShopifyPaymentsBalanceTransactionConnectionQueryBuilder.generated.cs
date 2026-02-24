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
    public sealed class ShopifyPaymentsBalanceTransactionConnectionQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsBalanceTransactionConnection, ShopifyPaymentsBalanceTransactionConnectionQueryBuilder>, IHasArguments<ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder>
    {
        public ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder Arguments { get; }
        protected override ShopifyPaymentsBalanceTransactionConnectionQueryBuilder Self => this;

        public ShopifyPaymentsBalanceTransactionConnectionQueryBuilder() : this("shopifyPaymentsBalanceTransactionConnection")
        {
        }

        public ShopifyPaymentsBalanceTransactionConnectionQueryBuilder(string name) : base(new Query<ShopifyPaymentsBalanceTransactionConnection>(name))
        {
            Arguments = new ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyPaymentsBalanceTransactionConnectionQueryBuilder(IQuery<ShopifyPaymentsBalanceTransactionConnection> query) : base(query)
        {
            Arguments = new ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyPaymentsBalanceTransactionConnectionQueryBuilder SetArguments(Action<ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionEdgeQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsBalanceTransactionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsBalanceTransactionEdge>(query);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsBalanceTransaction>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsBalanceTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsBalanceTransaction>(query);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}