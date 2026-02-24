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
    public sealed class ProductOptionTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, ProductOptionTranslationsQueryBuilder>, IHasArguments<ProductOptionTranslationsArgumentsBuilder>
    {
        public ProductOptionTranslationsArgumentsBuilder Arguments { get; }
        protected override ProductOptionTranslationsQueryBuilder Self => this;

        public ProductOptionTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new ProductOptionTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ProductOptionTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new ProductOptionTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ProductOptionTranslationsQueryBuilder SetArguments(Action<ProductOptionTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductOptionTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public ProductOptionTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public ProductOptionTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public ProductOptionTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public ProductOptionTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public ProductOptionTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}