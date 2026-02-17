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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class GiftCardsOperationQueryBuilder : FieldsQueryBuilderBase<GiftCardConnection, GiftCardsOperationQueryBuilder>, IGraphOperationQueryBuilder<GiftCardConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public GiftCardsArgumentsBuilder Arguments { get; }
        protected override GiftCardsOperationQueryBuilder Self => this;

        public GiftCardsOperationQueryBuilder() : this("giftCards")
        {
        }

        public GiftCardsOperationQueryBuilder(string name) : base(new Query<GiftCardConnection>(name))
        {
            Arguments = new GiftCardsArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardsOperationQueryBuilder(IQuery<GiftCardConnection> query) : base(query)
        {
            Arguments = new GiftCardsArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardEdgeQueryBuilder> build)
        {
            var query = new Query<GiftCardEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardEdge>(query);
            return this;
        }

        public GiftCardsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public GiftCardsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}