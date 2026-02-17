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
    public sealed class ArticleUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<ArticleUpdateUserError, ArticleUpdateUserErrorQueryBuilder>
    {
        protected override ArticleUpdateUserErrorQueryBuilder Self => this;

        public ArticleUpdateUserErrorQueryBuilder() : this("articleUpdateUserError")
        {
        }

        public ArticleUpdateUserErrorQueryBuilder(string name) : base(new Query<ArticleUpdateUserError>(name))
        {
        }

        public ArticleUpdateUserErrorQueryBuilder(IQuery<ArticleUpdateUserError> query) : base(query)
        {
        }

        public ArticleUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ArticleUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ArticleUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}