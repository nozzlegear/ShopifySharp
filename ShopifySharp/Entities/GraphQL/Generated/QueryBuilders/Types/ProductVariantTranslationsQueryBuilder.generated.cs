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
    public sealed class ProductVariantTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, ProductVariantTranslationsQueryBuilder>, IHasArguments<ProductVariantTranslationsArgumentsBuilder>
    {
        public ProductVariantTranslationsArgumentsBuilder Arguments { get; }
        protected override ProductVariantTranslationsQueryBuilder Self => this;

        public ProductVariantTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new ProductVariantTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new ProductVariantTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantTranslationsQueryBuilder SetArguments(Action<ProductVariantTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductVariantTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public ProductVariantTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public ProductVariantTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public ProductVariantTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public ProductVariantTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public ProductVariantTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}