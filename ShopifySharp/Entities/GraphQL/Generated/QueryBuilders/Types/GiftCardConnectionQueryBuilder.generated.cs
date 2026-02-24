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
    public sealed class GiftCardConnectionQueryBuilder : FieldsQueryBuilderBase<GiftCardConnection, GiftCardConnectionQueryBuilder>, IHasArguments<GiftCardConnectionArgumentsBuilder>
    {
        public GiftCardConnectionArgumentsBuilder Arguments { get; }
        protected override GiftCardConnectionQueryBuilder Self => this;

        public GiftCardConnectionQueryBuilder() : this("giftCardConnection")
        {
        }

        public GiftCardConnectionQueryBuilder(string name) : base(new Query<GiftCardConnection>(name))
        {
            Arguments = new GiftCardConnectionArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardConnectionQueryBuilder(IQuery<GiftCardConnection> query) : base(query)
        {
            Arguments = new GiftCardConnectionArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardConnectionQueryBuilder SetArguments(Action<GiftCardConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public GiftCardConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardEdgeQueryBuilder> build)
        {
            var query = new Query<GiftCardEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardEdge>(query);
            return this;
        }

        public GiftCardConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public GiftCardConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}