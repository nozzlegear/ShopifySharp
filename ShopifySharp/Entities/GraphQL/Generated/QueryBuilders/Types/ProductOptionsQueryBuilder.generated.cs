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
    public sealed class ProductOptionsQueryBuilder : FieldsQueryBuilderBase<ProductOption, ProductOptionsQueryBuilder>, IHasArguments<ProductOptionsArgumentsBuilder>
    {
        public ProductOptionsArgumentsBuilder Arguments { get; }
        protected override ProductOptionsQueryBuilder Self => this;

        public ProductOptionsQueryBuilder(string name) : base(new Query<ProductOption>(name))
        {
            Arguments = new ProductOptionsArgumentsBuilder(base.InnerQuery);
        }

        public ProductOptionsQueryBuilder(IQuery<ProductOption> query) : base(query)
        {
            Arguments = new ProductOptionsArgumentsBuilder(base.InnerQuery);
        }

        public ProductOptionsQueryBuilder SetArguments(Action<ProductOptionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ProductOptionsQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductOptionsQueryBuilder LinkedMetafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LinkedMetafieldQueryBuilder> build)
        {
            var query = new Query<LinkedMetafield>("linkedMetafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LinkedMetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LinkedMetafield>(query);
            return this;
        }

        public ProductOptionsQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public ProductOptionsQueryBuilder OptionValues(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionValueQueryBuilder> build)
        {
            var query = new Query<ProductOptionValue>("optionValues");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOptionValue>(query);
            return this;
        }

        public ProductOptionsQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }

        public ProductOptionsQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public ProductOptionsQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}