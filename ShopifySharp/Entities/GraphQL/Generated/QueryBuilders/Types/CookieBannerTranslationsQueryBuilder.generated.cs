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
    public sealed class CookieBannerTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, CookieBannerTranslationsQueryBuilder>, IHasArguments<CookieBannerTranslationsArgumentsBuilder>
    {
        public CookieBannerTranslationsArgumentsBuilder Arguments { get; }
        protected override CookieBannerTranslationsQueryBuilder Self => this;

        public CookieBannerTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new CookieBannerTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public CookieBannerTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new CookieBannerTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public CookieBannerTranslationsQueryBuilder SetArguments(Action<CookieBannerTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CookieBannerTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public CookieBannerTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public CookieBannerTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public CookieBannerTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public CookieBannerTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public CookieBannerTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}