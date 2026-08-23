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
    public sealed class CommentEventEmbedOptionsQueryBuilder : FieldsQueryBuilderBase<ProductOption, CommentEventEmbedOptionsQueryBuilder>, IHasArguments<CommentEventEmbedOptionsArgumentsBuilder>
    {
        public CommentEventEmbedOptionsArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedOptionsQueryBuilder Self => this;

        public CommentEventEmbedOptionsQueryBuilder(string name) : base(new Query<ProductOption>(name))
        {
            Arguments = new CommentEventEmbedOptionsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedOptionsQueryBuilder(IQuery<ProductOption> query) : base(query)
        {
            Arguments = new CommentEventEmbedOptionsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedOptionsQueryBuilder SetArguments(Action<CommentEventEmbedOptionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedOptionsQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CommentEventEmbedOptionsQueryBuilder LinkedMetafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LinkedMetafieldQueryBuilder> build)
        {
            var query = new Query<LinkedMetafield>("linkedMetafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LinkedMetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LinkedMetafield>(query);
            return this;
        }

        public CommentEventEmbedOptionsQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CommentEventEmbedOptionsQueryBuilder OptionValues(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionValueQueryBuilder> build)
        {
            var query = new Query<ProductOptionValue>("optionValues");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOptionValue>(query);
            return this;
        }

        public CommentEventEmbedOptionsQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }

        public CommentEventEmbedOptionsQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public CommentEventEmbedOptionsQueryBuilder Values()
        {
            base.InnerQuery.AddField("values");
            return this;
        }
    }
}