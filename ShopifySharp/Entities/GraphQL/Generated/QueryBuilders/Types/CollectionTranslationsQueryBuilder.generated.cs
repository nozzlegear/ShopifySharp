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
    public sealed class CollectionTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, CollectionTranslationsQueryBuilder>, IHasArguments<CollectionTranslationsArgumentsBuilder>
    {
        public CollectionTranslationsArgumentsBuilder Arguments { get; }
        protected override CollectionTranslationsQueryBuilder Self => this;

        public CollectionTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new CollectionTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new CollectionTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public CollectionTranslationsQueryBuilder SetArguments(Action<CollectionTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CollectionTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public CollectionTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public CollectionTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public CollectionTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public CollectionTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public CollectionTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}