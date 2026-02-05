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
    public sealed class DraftOrderConnectionQueryBuilder : FieldsQueryBuilderBase<DraftOrderConnection, DraftOrderConnectionQueryBuilder>
    {
        protected override DraftOrderConnectionQueryBuilder Self => this;

        public DraftOrderConnectionQueryBuilder() : this("draftOrderConnection")
        {
        }

        public DraftOrderConnectionQueryBuilder(string name) : base(new Query<DraftOrderConnection>(name))
        {
        }

        public DraftOrderConnectionQueryBuilder(IQuery<DraftOrderConnection> query) : base(query)
        {
        }

        public DraftOrderConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderEdgeQueryBuilder> build)
        {
            var query = new Query<DraftOrderEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderEdge>(query);
            return this;
        }

        public DraftOrderConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public DraftOrderConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}