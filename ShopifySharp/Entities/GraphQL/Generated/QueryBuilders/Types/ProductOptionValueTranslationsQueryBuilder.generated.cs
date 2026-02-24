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
    public sealed class ProductOptionValueTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, ProductOptionValueTranslationsQueryBuilder>, IHasArguments<ProductOptionValueTranslationsArgumentsBuilder>
    {
        public ProductOptionValueTranslationsArgumentsBuilder Arguments { get; }
        protected override ProductOptionValueTranslationsQueryBuilder Self => this;

        public ProductOptionValueTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new ProductOptionValueTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ProductOptionValueTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new ProductOptionValueTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ProductOptionValueTranslationsQueryBuilder SetArguments(Action<ProductOptionValueTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductOptionValueTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public ProductOptionValueTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public ProductOptionValueTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public ProductOptionValueTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public ProductOptionValueTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public ProductOptionValueTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}