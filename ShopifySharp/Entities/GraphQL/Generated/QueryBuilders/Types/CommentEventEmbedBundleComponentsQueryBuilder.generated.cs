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
    public sealed class CommentEventEmbedBundleComponentsQueryBuilder : FieldsQueryBuilderBase<ProductBundleComponentConnection, CommentEventEmbedBundleComponentsQueryBuilder>, IHasArguments<CommentEventEmbedBundleComponentsArgumentsBuilder>
    {
        public CommentEventEmbedBundleComponentsArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedBundleComponentsQueryBuilder Self => this;

        public CommentEventEmbedBundleComponentsQueryBuilder(string name) : base(new Query<ProductBundleComponentConnection>(name))
        {
            Arguments = new CommentEventEmbedBundleComponentsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedBundleComponentsQueryBuilder(IQuery<ProductBundleComponentConnection> query) : base(query)
        {
            Arguments = new CommentEventEmbedBundleComponentsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedBundleComponentsQueryBuilder SetArguments(Action<CommentEventEmbedBundleComponentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedBundleComponentsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleComponentEdgeQueryBuilder> build)
        {
            var query = new Query<ProductBundleComponentEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleComponentEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleComponentEdge>(query);
            return this;
        }

        public CommentEventEmbedBundleComponentsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleComponentQueryBuilder> build)
        {
            var query = new Query<ProductBundleComponent>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleComponentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleComponent>(query);
            return this;
        }

        public CommentEventEmbedBundleComponentsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}