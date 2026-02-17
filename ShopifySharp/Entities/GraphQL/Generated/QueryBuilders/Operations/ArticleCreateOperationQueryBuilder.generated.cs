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
    public sealed class ArticleCreateOperationQueryBuilder : FieldsQueryBuilderBase<ArticleCreatePayload, ArticleCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<ArticleCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ArticleCreateArgumentsBuilder Arguments { get; }
        protected override ArticleCreateOperationQueryBuilder Self => this;

        public ArticleCreateOperationQueryBuilder() : this("articleCreate")
        {
        }

        public ArticleCreateOperationQueryBuilder(string name) : base(new Query<ArticleCreatePayload>(name))
        {
            Arguments = new ArticleCreateArgumentsBuilder(base.InnerQuery);
        }

        public ArticleCreateOperationQueryBuilder(IQuery<ArticleCreatePayload> query) : base(query)
        {
            Arguments = new ArticleCreateArgumentsBuilder(base.InnerQuery);
        }

        public ArticleCreateOperationQueryBuilder Article(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("article");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Article>(query);
            return this;
        }

        public ArticleCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ArticleCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<ArticleCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ArticleCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleCreateUserError>(query);
            return this;
        }
    }
}