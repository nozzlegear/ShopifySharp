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
    public sealed class TranslatableResourceTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, TranslatableResourceTranslationsQueryBuilder>, IHasArguments<TranslatableResourceTranslationsArgumentsBuilder>
    {
        public TranslatableResourceTranslationsArgumentsBuilder Arguments { get; }
        protected override TranslatableResourceTranslationsQueryBuilder Self => this;

        public TranslatableResourceTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new TranslatableResourceTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public TranslatableResourceTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new TranslatableResourceTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public TranslatableResourceTranslationsQueryBuilder SetArguments(Action<TranslatableResourceTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public TranslatableResourceTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public TranslatableResourceTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public TranslatableResourceTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public TranslatableResourceTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public TranslatableResourceTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public TranslatableResourceTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}