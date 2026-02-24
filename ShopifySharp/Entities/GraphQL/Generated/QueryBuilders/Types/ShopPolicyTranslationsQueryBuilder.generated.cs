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
    public sealed class ShopPolicyTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, ShopPolicyTranslationsQueryBuilder>, IHasArguments<ShopPolicyTranslationsArgumentsBuilder>
    {
        public ShopPolicyTranslationsArgumentsBuilder Arguments { get; }
        protected override ShopPolicyTranslationsQueryBuilder Self => this;

        public ShopPolicyTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new ShopPolicyTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ShopPolicyTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new ShopPolicyTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public ShopPolicyTranslationsQueryBuilder SetArguments(Action<ShopPolicyTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ShopPolicyTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public ShopPolicyTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public ShopPolicyTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public ShopPolicyTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public ShopPolicyTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public ShopPolicyTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}