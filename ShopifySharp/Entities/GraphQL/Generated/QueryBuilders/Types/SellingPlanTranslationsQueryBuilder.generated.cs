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
    public sealed class SellingPlanTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, SellingPlanTranslationsQueryBuilder>, IHasArguments<SellingPlanTranslationsArgumentsBuilder>
    {
        public SellingPlanTranslationsArgumentsBuilder Arguments { get; }
        protected override SellingPlanTranslationsQueryBuilder Self => this;

        public SellingPlanTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new SellingPlanTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new SellingPlanTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanTranslationsQueryBuilder SetArguments(Action<SellingPlanTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SellingPlanTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public SellingPlanTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public SellingPlanTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public SellingPlanTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public SellingPlanTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public SellingPlanTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}