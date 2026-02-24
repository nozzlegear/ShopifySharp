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
    public sealed class PageTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, PageTranslationsQueryBuilder>, IHasArguments<PageTranslationsArgumentsBuilder>
    {
        public PageTranslationsArgumentsBuilder Arguments { get; }
        protected override PageTranslationsQueryBuilder Self => this;

        public PageTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new PageTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public PageTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new PageTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public PageTranslationsQueryBuilder SetArguments(Action<PageTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PageTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public PageTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public PageTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public PageTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public PageTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public PageTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}