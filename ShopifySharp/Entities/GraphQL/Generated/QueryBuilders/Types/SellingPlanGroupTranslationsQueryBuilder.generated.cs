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
    public sealed class SellingPlanGroupTranslationsQueryBuilder : FieldsQueryBuilderBase<Translation, SellingPlanGroupTranslationsQueryBuilder>, IHasArguments<SellingPlanGroupTranslationsArgumentsBuilder>
    {
        public SellingPlanGroupTranslationsArgumentsBuilder Arguments { get; }
        protected override SellingPlanGroupTranslationsQueryBuilder Self => this;

        public SellingPlanGroupTranslationsQueryBuilder(string name) : base(new Query<Translation>(name))
        {
            Arguments = new SellingPlanGroupTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupTranslationsQueryBuilder(IQuery<Translation> query) : base(query)
        {
            Arguments = new SellingPlanGroupTranslationsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupTranslationsQueryBuilder SetArguments(Action<SellingPlanGroupTranslationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SellingPlanGroupTranslationsQueryBuilder Key()
        {
            base.InnerQuery.AddField("key");
            return this;
        }

        public SellingPlanGroupTranslationsQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public SellingPlanGroupTranslationsQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public SellingPlanGroupTranslationsQueryBuilder Outdated()
        {
            base.InnerQuery.AddField("outdated");
            return this;
        }

        public SellingPlanGroupTranslationsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public SellingPlanGroupTranslationsQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}