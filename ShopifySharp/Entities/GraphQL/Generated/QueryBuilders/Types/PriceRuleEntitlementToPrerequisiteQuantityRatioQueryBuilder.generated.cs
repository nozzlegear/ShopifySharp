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
    public sealed class PriceRuleEntitlementToPrerequisiteQuantityRatioQueryBuilder : FieldsQueryBuilderBase<PriceRuleEntitlementToPrerequisiteQuantityRatio, PriceRuleEntitlementToPrerequisiteQuantityRatioQueryBuilder>
    {
        protected override PriceRuleEntitlementToPrerequisiteQuantityRatioQueryBuilder Self => this;

        public PriceRuleEntitlementToPrerequisiteQuantityRatioQueryBuilder() : this("priceRuleEntitlementToPrerequisiteQuantityRatio")
        {
        }

        public PriceRuleEntitlementToPrerequisiteQuantityRatioQueryBuilder(string name) : base(new Query<PriceRuleEntitlementToPrerequisiteQuantityRatio>(name))
        {
        }

        public PriceRuleEntitlementToPrerequisiteQuantityRatioQueryBuilder(IQuery<PriceRuleEntitlementToPrerequisiteQuantityRatio> query) : base(query)
        {
        }

        public PriceRuleEntitlementToPrerequisiteQuantityRatioQueryBuilder EntitlementQuantity()
        {
            base.InnerQuery.AddField("entitlementQuantity");
            return this;
        }

        public PriceRuleEntitlementToPrerequisiteQuantityRatioQueryBuilder PrerequisiteQuantity()
        {
            base.InnerQuery.AddField("prerequisiteQuantity");
            return this;
        }
    }
}