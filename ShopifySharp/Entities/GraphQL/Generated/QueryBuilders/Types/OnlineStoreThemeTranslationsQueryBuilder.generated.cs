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
    public sealed class OnlineStoreThemeTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, OnlineStoreThemeTranslationsQueryBuilder>, IHasArguments<OnlineStoreThemeTranslationsArgumentsBuilder>
    {
        public OnlineStoreThemeTranslationsArgumentsBuilder Arguments { get; }
        protected override OnlineStoreThemeTranslationsQueryBuilder Self => this;

        public OnlineStoreThemeTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new OnlineStoreThemeTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public OnlineStoreThemeTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new OnlineStoreThemeTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public OnlineStoreThemeTranslationsQueryBuilder SetArguments(Action<OnlineStoreThemeTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OnlineStoreThemeTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public OnlineStoreThemeTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public OnlineStoreThemeTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public OnlineStoreThemeTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public OnlineStoreThemeTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public OnlineStoreThemeTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}