#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class PriceRuleDiscountCodeQueryBuilder : FieldsQueryBuilderBase<PriceRuleDiscountCode, PriceRuleDiscountCodeQueryBuilder>
    {
        protected override PriceRuleDiscountCodeQueryBuilder Self => this;

        public PriceRuleDiscountCodeQueryBuilder() : this("priceRuleDiscountCode")
        {
        }

        public PriceRuleDiscountCodeQueryBuilder(string name) : base(new Query<PriceRuleDiscountCode>(name))
        {
        }

        public PriceRuleDiscountCodeQueryBuilder(IQuery<PriceRuleDiscountCode> query) : base(query)
        {
        }

        public PriceRuleDiscountCodeQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public PriceRuleDiscountCodeQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public PriceRuleDiscountCodeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PriceRuleDiscountCodeQueryBuilder UsageCount()
        {
            base.InnerQuery.AddField("usageCount");
            return this;
        }
    }
}