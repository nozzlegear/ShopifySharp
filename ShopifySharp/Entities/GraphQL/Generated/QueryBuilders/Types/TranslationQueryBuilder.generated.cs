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
    public sealed class TranslationQueryBuilder : FieldsQueryBuilderBase<Translation, TranslationQueryBuilder>
    {
        protected override TranslationQueryBuilder Self => this;

        public TranslationQueryBuilder() : this("translation")
        {
        }

        public TranslationQueryBuilder(string name) : base(new Query<Translation>(name))
        {
        }

        public TranslationQueryBuilder(IQuery<Translation> query) : base(query)
        {
        }

        public TranslationQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public TranslationQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public TranslationQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public TranslationQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public TranslationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public TranslationQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}