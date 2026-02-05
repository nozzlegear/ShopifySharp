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
    public sealed class DiscountApplicationConnectionQueryBuilder : FieldsQueryBuilderBase<DiscountApplicationConnection, DiscountApplicationConnectionQueryBuilder>
    {
        protected override DiscountApplicationConnectionQueryBuilder Self => this;

        public DiscountApplicationConnectionQueryBuilder() : this("discountApplicationConnection")
        {
        }

        public DiscountApplicationConnectionQueryBuilder(string name) : base(new Query<DiscountApplicationConnection>(name))
        {
        }

        public DiscountApplicationConnectionQueryBuilder(IQuery<DiscountApplicationConnection> query) : base(query)
        {
        }

        public DiscountApplicationConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountApplicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountApplicationEdge>(query);
            return this;
        }

        public DiscountApplicationConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationQueryBuilder> build)
        {
            var query = new Query<IDiscountApplication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IDiscountApplication>(query);
            return this;
        }

        public DiscountApplicationConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}