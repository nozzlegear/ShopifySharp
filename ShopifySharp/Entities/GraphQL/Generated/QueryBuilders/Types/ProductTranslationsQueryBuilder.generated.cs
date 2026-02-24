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
    public sealed class ProductTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, ProductTranslationsQueryBuilder>, IHasArguments<ProductTranslationsArgumentsBuilder>
    {
        public ProductTranslationsArgumentsBuilder Arguments { get; }
        protected override ProductTranslationsQueryBuilder Self => this;

        public ProductTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new ProductTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ProductTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new ProductTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ProductTranslationsQueryBuilder SetArguments(Action<ProductTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public ProductTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public ProductTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public ProductTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public ProductTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public ProductTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}