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
    public sealed class ArticleCreateUserErrorQueryBuilder : FieldsQueryBuilderBase<ArticleCreateUserError, ArticleCreateUserErrorQueryBuilder>
    {
        protected override ArticleCreateUserErrorQueryBuilder Self => this;

        public ArticleCreateUserErrorQueryBuilder() : this("articleCreateUserError")
        {
        }

        public ArticleCreateUserErrorQueryBuilder(string name) : base(new Query<ArticleCreateUserError>(name))
        {
        }

        public ArticleCreateUserErrorQueryBuilder(IQuery<ArticleCreateUserError> query) : base(query)
        {
        }

        public ArticleCreateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ArticleCreateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ArticleCreateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}