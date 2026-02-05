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
    public sealed class LinkQueryBuilder : FieldsQueryBuilderBase<Link, LinkQueryBuilder>
    {
        protected override LinkQueryBuilder Self => this;

        public LinkQueryBuilder() : this("link")
        {
        }

        public LinkQueryBuilder(string name) : base(new Query<Link>(name))
        {
        }

        public LinkQueryBuilder(IQuery<Link> query) : base(query)
        {
        }

        public LinkQueryBuilder Label()
        {
            base.InnerQuery.AddField("label");
            return this;
        }

        public LinkQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public LinkQueryBuilder Url()
        {
            base.InnerQuery.AddField("url");
            return this;
        }
    }
}