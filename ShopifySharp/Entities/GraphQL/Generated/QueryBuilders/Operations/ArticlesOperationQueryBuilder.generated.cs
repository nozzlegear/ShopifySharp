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
    public sealed class ArticlesOperationQueryBuilder : FieldsQueryBuilderBase<ArticleConnection, ArticlesOperationQueryBuilder>, IGraphOperationQueryBuilder<ArticleConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ArticlesArgumentsBuilder Arguments { get; }
        protected override ArticlesOperationQueryBuilder Self => this;

        public ArticlesOperationQueryBuilder() : this("articles")
        {
        }

        public ArticlesOperationQueryBuilder(string name) : base(new Query<ArticleConnection>(name))
        {
            Arguments = new ArticlesArgumentsBuilder(base.InnerQuery);
        }

        public ArticlesOperationQueryBuilder(IQuery<ArticleConnection> query) : base(query)
        {
            Arguments = new ArticlesArgumentsBuilder(base.InnerQuery);
        }

        public ArticlesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleEdgeQueryBuilder> build)
        {
            var query = new Query<ArticleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleEdge>(query);
            return this;
        }

        public ArticlesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Article>(query);
            return this;
        }

        public ArticlesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}