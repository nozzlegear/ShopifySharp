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
    public sealed class TenderTransactionConnectionQueryBuilder : FieldsQueryBuilderBase<TenderTransactionConnection, TenderTransactionConnectionQueryBuilder>
    {
        protected override TenderTransactionConnectionQueryBuilder Self => this;

        public TenderTransactionConnectionQueryBuilder() : this("tenderTransactionConnection")
        {
        }

        public TenderTransactionConnectionQueryBuilder(string name) : base(new Query<TenderTransactionConnection>(name))
        {
        }

        public TenderTransactionConnectionQueryBuilder(IQuery<TenderTransactionConnection> query) : base(query)
        {
        }

        public TenderTransactionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TenderTransactionEdgeQueryBuilder> build)
        {
            var query = new Query<TenderTransactionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TenderTransactionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TenderTransactionEdge>(query);
            return this;
        }

        public TenderTransactionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TenderTransactionQueryBuilder> build)
        {
            var query = new Query<TenderTransaction>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TenderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TenderTransaction>(query);
            return this;
        }

        public TenderTransactionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}