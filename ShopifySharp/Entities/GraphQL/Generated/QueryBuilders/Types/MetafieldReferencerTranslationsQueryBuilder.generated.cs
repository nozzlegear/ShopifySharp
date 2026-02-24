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
    public sealed class MetafieldReferencerTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, MetafieldReferencerTranslationsQueryBuilder>, IHasArguments<MetafieldReferencerTranslationsArgumentsBuilder>
    {
        public MetafieldReferencerTranslationsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerTranslationsQueryBuilder Self => this;

        public MetafieldReferencerTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new MetafieldReferencerTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new MetafieldReferencerTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerTranslationsQueryBuilder SetArguments(Action<MetafieldReferencerTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public MetafieldReferencerTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public MetafieldReferencerTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MetafieldReferencerTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public MetafieldReferencerTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public MetafieldReferencerTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}