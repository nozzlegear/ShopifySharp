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
    public sealed class CommentEventEmbedTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, CommentEventEmbedTranslationsQueryBuilder>, IHasArguments<CommentEventEmbedTranslationsArgumentsBuilder>
    {
        public CommentEventEmbedTranslationsArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedTranslationsQueryBuilder Self => this;

        public CommentEventEmbedTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new CommentEventEmbedTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new CommentEventEmbedTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedTranslationsQueryBuilder SetArguments(Action<CommentEventEmbedTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public CommentEventEmbedTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public CommentEventEmbedTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public CommentEventEmbedTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public CommentEventEmbedTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public CommentEventEmbedTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}