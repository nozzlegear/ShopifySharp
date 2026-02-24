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
    public sealed class MetafieldReferenceTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, MetafieldReferenceTranslationsQueryBuilder>, IHasArguments<MetafieldReferenceTranslationsArgumentsBuilder>
    {
        public MetafieldReferenceTranslationsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceTranslationsQueryBuilder Self => this;

        public MetafieldReferenceTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new MetafieldReferenceTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new MetafieldReferenceTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceTranslationsQueryBuilder SetArguments(Action<MetafieldReferenceTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MetafieldReferenceTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public MetafieldReferenceTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MetafieldReferenceTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public MetafieldReferenceTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public MetafieldReferenceTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}