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
    public sealed class ShopTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, ShopTranslationsQueryBuilder>, IHasArguments<ShopTranslationsArgumentsBuilder>
    {
        public ShopTranslationsArgumentsBuilder Arguments { get; }
        protected override ShopTranslationsQueryBuilder Self => this;

        public ShopTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new ShopTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ShopTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new ShopTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ShopTranslationsQueryBuilder SetArguments(Action<ShopTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShopTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public ShopTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public ShopTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public ShopTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public ShopTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public ShopTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}