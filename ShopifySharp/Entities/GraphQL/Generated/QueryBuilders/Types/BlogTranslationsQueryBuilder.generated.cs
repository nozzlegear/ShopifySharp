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
    public sealed class BlogTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, BlogTranslationsQueryBuilder>, IHasArguments<BlogTranslationsArgumentsBuilder>
    {
        public BlogTranslationsArgumentsBuilder Arguments { get; }
        protected override BlogTranslationsQueryBuilder Self => this;

        public BlogTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new BlogTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public BlogTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new BlogTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public BlogTranslationsQueryBuilder SetArguments(Action<BlogTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public BlogTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public BlogTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public BlogTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public BlogTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public BlogTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public BlogTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}