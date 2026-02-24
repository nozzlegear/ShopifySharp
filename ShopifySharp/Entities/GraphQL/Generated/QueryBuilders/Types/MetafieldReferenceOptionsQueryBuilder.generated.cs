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
    public sealed class MetafieldReferenceOptionsQueryBuilder : FieldsQueryBuilderBase<ProductOption, MetafieldReferenceOptionsQueryBuilder>, IHasArguments<MetafieldReferenceOptionsArgumentsBuilder>
    {
        public MetafieldReferenceOptionsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceOptionsQueryBuilder Self => this;

        public MetafieldReferenceOptionsQueryBuilder(string name) : base(new Query<ProductOption>(name))
        {
            Arguments = new MetafieldReferenceOptionsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceOptionsQueryBuilder(IQuery<ProductOption> query) : base(query)
        {
            Arguments = new MetafieldReferenceOptionsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceOptionsQueryBuilder SetArguments(Action<MetafieldReferenceOptionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceOptionsQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MetafieldReferenceOptionsQueryBuilder LinkedMetafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LinkedMetafieldQueryBuilder> build)
        {
            var query = new Query<LinkedMetafield>("linkedMetafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LinkedMetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LinkedMetafield>(query);
            return this;
        }

        public MetafieldReferenceOptionsQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MetafieldReferenceOptionsQueryBuilder OptionValues(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionValueQueryBuilder> build)
        {
            var query = new Query<ProductOptionValue>("optionValues");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOptionValue>(query);
            return this;
        }

        public MetafieldReferenceOptionsQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }

        public MetafieldReferenceOptionsQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public MetafieldReferenceOptionsQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}