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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ArticleUpdateOperationQueryBuilder : FieldsQueryBuilderBase<ArticleUpdatePayload, ArticleUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<ArticleUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ArticleUpdateArgumentsBuilder Arguments { get; }
        protected override ArticleUpdateOperationQueryBuilder Self => this;

        public ArticleUpdateOperationQueryBuilder() : this("articleUpdate")
        {
        }

        public ArticleUpdateOperationQueryBuilder(string name) : base(new Query<ArticleUpdatePayload>(name))
        {
            Arguments = new ArticleUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ArticleUpdateOperationQueryBuilder(IQuery<ArticleUpdatePayload> query) : base(query)
        {
            Arguments = new ArticleUpdateArgumentsBuilder(base.InnerQuery);
        }

        public ArticleUpdateOperationQueryBuilder Article(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("article");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Article>(query);
            return this;
        }

        public ArticleUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<ArticleUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleUpdateUserError>(query);
            return this;
        }
    }
}