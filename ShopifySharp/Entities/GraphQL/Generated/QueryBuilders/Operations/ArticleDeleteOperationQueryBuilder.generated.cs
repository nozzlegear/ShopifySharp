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
    public sealed class ArticleDeleteOperationQueryBuilder : FieldsQueryBuilderBase<ArticleDeletePayload, ArticleDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<ArticleDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ArticleDeleteArgumentsBuilder Arguments { get; }
        protected override ArticleDeleteOperationQueryBuilder Self => this;

        public ArticleDeleteOperationQueryBuilder() : this("articleDelete")
        {
        }

        public ArticleDeleteOperationQueryBuilder(string name) : base(new Query<ArticleDeletePayload>(name))
        {
            Arguments = new ArticleDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ArticleDeleteOperationQueryBuilder(IQuery<ArticleDeletePayload> query) : base(query)
        {
            Arguments = new ArticleDeleteArgumentsBuilder(base.InnerQuery);
        }

        public ArticleDeleteOperationQueryBuilder DeletedArticleId()
        {
            base.InnerQuery.AddField("deletedArticleId");
            return this;
        }

        public ArticleDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<ArticleDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleDeleteUserError>(query);
            return this;
        }
    }
}