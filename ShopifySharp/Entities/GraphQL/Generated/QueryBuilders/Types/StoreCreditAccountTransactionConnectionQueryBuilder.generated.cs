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
    public sealed class StoreCreditAccountTransactionConnectionQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountTransactionConnection, StoreCreditAccountTransactionConnectionQueryBuilder>
    {
        protected override StoreCreditAccountTransactionConnectionQueryBuilder Self => this;

        public StoreCreditAccountTransactionConnectionQueryBuilder() : this("storeCreditAccountTransactionConnection")
        {
        }

        public StoreCreditAccountTransactionConnectionQueryBuilder(string name) : base(new Query<StoreCreditAccountTransactionConnection>(name))
        {
        }

        public StoreCreditAccountTransactionConnectionQueryBuilder(IQuery<StoreCreditAccountTransactionConnection> query) : base(query)
        {
        }

        public StoreCreditAccountTransactionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountTransactionEdgeQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountTransactionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountTransactionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountTransactionEdge>(query);
            return this;
        }

        public StoreCreditAccountTransactionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountTransactionQueryBuilder> build)
        {
            var query = new Query<IStoreCreditAccountTransaction>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IStoreCreditAccountTransaction>(query);
            return this;
        }

        public StoreCreditAccountTransactionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}