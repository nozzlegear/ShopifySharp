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
    public sealed class GiftCardTransactionConnectionQueryBuilder : FieldsQueryBuilderBase<GiftCardTransactionConnection, GiftCardTransactionConnectionQueryBuilder>
    {
        protected override GiftCardTransactionConnectionQueryBuilder Self => this;

        public GiftCardTransactionConnectionQueryBuilder() : this("giftCardTransactionConnection")
        {
        }

        public GiftCardTransactionConnectionQueryBuilder(string name) : base(new Query<GiftCardTransactionConnection>(name))
        {
        }

        public GiftCardTransactionConnectionQueryBuilder(IQuery<GiftCardTransactionConnection> query) : base(query)
        {
        }

        public GiftCardTransactionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardTransactionEdgeQueryBuilder> build)
        {
            var query = new Query<GiftCardTransactionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardTransactionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardTransactionEdge>(query);
            return this;
        }

        public GiftCardTransactionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardTransactionQueryBuilder> build)
        {
            var query = new Query<IGiftCardTransaction>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IGiftCardTransaction>(query);
            return this;
        }

        public GiftCardTransactionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}