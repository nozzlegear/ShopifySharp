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
    public sealed class ArticleCreatePayloadQueryBuilder : FieldsQueryBuilderBase<ArticleCreatePayload, ArticleCreatePayloadQueryBuilder>
    {
        protected override ArticleCreatePayloadQueryBuilder Self => this;

        public ArticleCreatePayloadQueryBuilder() : this("articleCreatePayload")
        {
        }

        public ArticleCreatePayloadQueryBuilder(string name) : base(new Query<ArticleCreatePayload>(name))
        {
        }

        public ArticleCreatePayloadQueryBuilder(IQuery<ArticleCreatePayload> query) : base(query)
        {
        }

        public ArticleCreatePayloadQueryBuilder Article(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleQueryBuilder> build)
        {
            var query = new Query<Article>("article");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Article>(query);
            return this;
        }

        public ArticleCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<ArticleCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ArticleCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ArticleCreateUserError>(query);
            return this;
        }
    }
}