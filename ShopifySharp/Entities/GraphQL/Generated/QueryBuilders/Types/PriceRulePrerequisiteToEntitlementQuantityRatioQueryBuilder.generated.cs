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
    public sealed class PriceRulePrerequisiteToEntitlementQuantityRatioQueryBuilder : FieldsQueryBuilderBase<PriceRulePrerequisiteToEntitlementQuantityRatio, PriceRulePrerequisiteToEntitlementQuantityRatioQueryBuilder>
    {
        protected override PriceRulePrerequisiteToEntitlementQuantityRatioQueryBuilder Self => this;

        public PriceRulePrerequisiteToEntitlementQuantityRatioQueryBuilder() : this("priceRulePrerequisiteToEntitlementQuantityRatio")
        {
        }

        public PriceRulePrerequisiteToEntitlementQuantityRatioQueryBuilder(string name) : base(new Query<PriceRulePrerequisiteToEntitlementQuantityRatio>(name))
        {
        }

        public PriceRulePrerequisiteToEntitlementQuantityRatioQueryBuilder(IQuery<PriceRulePrerequisiteToEntitlementQuantityRatio> query) : base(query)
        {
        }

        public PriceRulePrerequisiteToEntitlementQuantityRatioQueryBuilder EntitlementQuantity()
        {
            base.InnerQuery.AddField("entitlementQuantity");
            return this;
        }

        public PriceRulePrerequisiteToEntitlementQuantityRatioQueryBuilder PrerequisiteQuantity()
        {
            base.InnerQuery.AddField("prerequisiteQuantity");
            return this;
        }
    }
}