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
    public sealed class ArticleDeleteUserErrorQueryBuilder : FieldsQueryBuilderBase<ArticleDeleteUserError, ArticleDeleteUserErrorQueryBuilder>
    {
        protected override ArticleDeleteUserErrorQueryBuilder Self => this;

        public ArticleDeleteUserErrorQueryBuilder() : this("articleDeleteUserError")
        {
        }

        public ArticleDeleteUserErrorQueryBuilder(string name) : base(new Query<ArticleDeleteUserError>(name))
        {
        }

        public ArticleDeleteUserErrorQueryBuilder(IQuery<ArticleDeleteUserError> query) : base(query)
        {
        }

        public ArticleDeleteUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ArticleDeleteUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ArticleDeleteUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}