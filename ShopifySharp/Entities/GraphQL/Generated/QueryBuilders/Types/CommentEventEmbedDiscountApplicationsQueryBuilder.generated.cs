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
    public sealed class CommentEventEmbedDiscountApplicationsQueryBuilder : FieldsQueryBuilderBase<DiscountApplicationConnection, CommentEventEmbedDiscountApplicationsQueryBuilder>, IHasArguments<CommentEventEmbedDiscountApplicationsArgumentsBuilder>
    {
        public CommentEventEmbedDiscountApplicationsArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedDiscountApplicationsQueryBuilder Self => this;

        public CommentEventEmbedDiscountApplicationsQueryBuilder(string name) : base(new Query<DiscountApplicationConnection>(name))
        {
            Arguments = new CommentEventEmbedDiscountApplicationsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedDiscountApplicationsQueryBuilder(IQuery<DiscountApplicationConnection> query) : base(query)
        {
            Arguments = new CommentEventEmbedDiscountApplicationsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedDiscountApplicationsQueryBuilder SetArguments(Action<CommentEventEmbedDiscountApplicationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedDiscountApplicationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountApplicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountApplicationEdge>(query);
            return this;
        }

        public CommentEventEmbedDiscountApplicationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public CommentEventEmbedDiscountApplicationsQueryBuilder Nodes(Action<DiscountApplicationInterfaceCasesBuilder> build)
        {
            var query = new Query<IDiscountApplication>("nodes");
            var unionBuilder = new DiscountApplicationInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}