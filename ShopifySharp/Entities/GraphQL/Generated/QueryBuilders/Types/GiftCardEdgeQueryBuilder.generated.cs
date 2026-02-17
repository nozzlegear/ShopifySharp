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
    public sealed class GiftCardEdgeQueryBuilder : FieldsQueryBuilderBase<GiftCardEdge, GiftCardEdgeQueryBuilder>
    {
        protected override GiftCardEdgeQueryBuilder Self => this;

        public GiftCardEdgeQueryBuilder() : this("giftCardEdge")
        {
        }

        public GiftCardEdgeQueryBuilder(string name) : base(new Query<GiftCardEdge>(name))
        {
        }

        public GiftCardEdgeQueryBuilder(IQuery<GiftCardEdge> query) : base(query)
        {
        }

        public GiftCardEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public GiftCardEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }
    }
}