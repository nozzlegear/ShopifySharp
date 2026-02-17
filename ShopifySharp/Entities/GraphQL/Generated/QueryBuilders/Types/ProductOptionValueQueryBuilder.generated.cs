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
    public sealed class ProductOptionValueQueryBuilder : FieldsQueryBuilderBase<ProductOptionValue, ProductOptionValueQueryBuilder>
    {
        protected override ProductOptionValueQueryBuilder Self => this;

        public ProductOptionValueQueryBuilder() : this("productOptionValue")
        {
        }

        public ProductOptionValueQueryBuilder(string name) : base(new Query<ProductOptionValue>(name))
        {
        }

        public ProductOptionValueQueryBuilder(IQuery<ProductOptionValue> query) : base(query)
        {
        }

        public ProductOptionValueQueryBuilder HasVariants()
        {
            base.InnerQuery.AddField("hasVariants");
            return this;
        }

        public ProductOptionValueQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductOptionValueQueryBuilder LinkedMetafieldValue()
        {
            base.InnerQuery.AddField("linkedMetafieldValue");
            return this;
        }

        public ProductOptionValueQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ProductOptionValueQueryBuilder Swatch(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionValueSwatchQueryBuilder> build)
        {
            var query = new Query<ProductOptionValueSwatch>("swatch");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionValueSwatchQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOptionValueSwatch>(query);
            return this;
        }

        public ProductOptionValueQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }
    }
}