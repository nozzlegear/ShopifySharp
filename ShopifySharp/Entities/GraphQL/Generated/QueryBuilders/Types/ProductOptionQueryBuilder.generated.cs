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
    public sealed class ProductOptionQueryBuilder : FieldsQueryBuilderBase<ProductOption, ProductOptionQueryBuilder>
    {
        protected override ProductOptionQueryBuilder Self => this;

        public ProductOptionQueryBuilder() : this("productOption")
        {
        }

        public ProductOptionQueryBuilder(string name) : base(new Query<ProductOption>(name))
        {
        }

        public ProductOptionQueryBuilder(IQuery<ProductOption> query) : base(query)
        {
        }

        public ProductOptionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductOptionQueryBuilder LinkedMetafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LinkedMetafieldQueryBuilder> build)
        {
            var query = new Query<LinkedMetafield>("linkedMetafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LinkedMetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LinkedMetafield>(query);
            return this;
        }

        public ProductOptionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ProductOptionQueryBuilder OptionValues(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionValueQueryBuilder> build)
        {
            var query = new Query<ProductOptionValue>("optionValues");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOptionValue>(query);
            return this;
        }

        public ProductOptionQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }

        public ProductOptionQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public ProductOptionQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}