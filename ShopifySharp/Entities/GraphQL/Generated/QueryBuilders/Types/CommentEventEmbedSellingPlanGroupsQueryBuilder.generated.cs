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
    public sealed class CommentEventEmbedSellingPlanGroupsQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupConnection, CommentEventEmbedSellingPlanGroupsQueryBuilder>, IHasArguments<CommentEventEmbedSellingPlanGroupsArgumentsBuilder>
    {
        public CommentEventEmbedSellingPlanGroupsArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedSellingPlanGroupsQueryBuilder Self => this;

        public CommentEventEmbedSellingPlanGroupsQueryBuilder(string name) : base(new Query<SellingPlanGroupConnection>(name))
        {
            Arguments = new CommentEventEmbedSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedSellingPlanGroupsQueryBuilder(IQuery<SellingPlanGroupConnection> query) : base(query)
        {
            Arguments = new CommentEventEmbedSellingPlanGroupsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedSellingPlanGroupsQueryBuilder SetArguments(Action<CommentEventEmbedSellingPlanGroupsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedSellingPlanGroupsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupEdgeQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupEdge>(query);
            return this;
        }

        public CommentEventEmbedSellingPlanGroupsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }

        public CommentEventEmbedSellingPlanGroupsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}