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
    public sealed class ArticleTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, ArticleTranslationsQueryBuilder>, IHasArguments<ArticleTranslationsArgumentsBuilder>
    {
        public ArticleTranslationsArgumentsBuilder Arguments { get; }
        protected override ArticleTranslationsQueryBuilder Self => this;

        public ArticleTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new ArticleTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ArticleTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new ArticleTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ArticleTranslationsQueryBuilder SetArguments(Action<ArticleTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ArticleTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public ArticleTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public ArticleTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public ArticleTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public ArticleTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public ArticleTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}