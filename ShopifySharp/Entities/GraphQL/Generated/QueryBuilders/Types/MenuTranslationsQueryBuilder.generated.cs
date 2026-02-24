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
    public sealed class MenuTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, MenuTranslationsQueryBuilder>, IHasArguments<MenuTranslationsArgumentsBuilder>
    {
        public MenuTranslationsArgumentsBuilder Arguments { get; }
        protected override MenuTranslationsQueryBuilder Self => this;

        public MenuTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new MenuTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public MenuTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new MenuTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public MenuTranslationsQueryBuilder SetArguments(Action<MenuTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MenuTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MenuTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public MenuTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MenuTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public MenuTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public MenuTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}