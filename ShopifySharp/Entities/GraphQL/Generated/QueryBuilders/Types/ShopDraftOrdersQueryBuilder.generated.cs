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
    public sealed class ShopDraftOrdersQueryBuilder : FieldsQueryBuilderBase<DraftOrderConnection, ShopDraftOrdersQueryBuilder>, IHasArguments<ShopDraftOrdersArgumentsBuilder>
    {
        public ShopDraftOrdersArgumentsBuilder Arguments { get; }
        protected override ShopDraftOrdersQueryBuilder Self => this;

        public ShopDraftOrdersQueryBuilder(string name) : base(new Query<DraftOrderConnection>(name))
        {
            Arguments = new ShopDraftOrdersArgumentsBuilder(base.InnerQuery);
        }

        public ShopDraftOrdersQueryBuilder(IQuery<DraftOrderConnection> query) : base(query)
        {
            Arguments = new ShopDraftOrdersArgumentsBuilder(base.InnerQuery);
        }

        public ShopDraftOrdersQueryBuilder SetArguments(Action<ShopDraftOrdersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShopDraftOrdersQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderEdgeQueryBuilder> build)
        {
            var query = new Query<DraftOrderEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderEdge>(query);
            return this;
        }

        public ShopDraftOrdersQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public ShopDraftOrdersQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}