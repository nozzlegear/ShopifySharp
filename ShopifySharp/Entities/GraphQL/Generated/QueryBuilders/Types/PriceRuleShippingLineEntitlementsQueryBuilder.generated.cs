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
    public sealed class PriceRuleShippingLineEntitlementsQueryBuilder : FieldsQueryBuilderBase<PriceRuleShippingLineEntitlements, PriceRuleShippingLineEntitlementsQueryBuilder>
    {
        protected override PriceRuleShippingLineEntitlementsQueryBuilder Self => this;

        public PriceRuleShippingLineEntitlementsQueryBuilder() : this("priceRuleShippingLineEntitlements")
        {
        }

        public PriceRuleShippingLineEntitlementsQueryBuilder(string name) : base(new Query<PriceRuleShippingLineEntitlements>(name))
        {
        }

        public PriceRuleShippingLineEntitlementsQueryBuilder(IQuery<PriceRuleShippingLineEntitlements> query) : base(query)
        {
        }

        public PriceRuleShippingLineEntitlementsQueryBuilder CountryCodes()
        {
            base.InnerQuery.AddField("countryCodes");
            return this;
        }

        public PriceRuleShippingLineEntitlementsQueryBuilder IncludeRestOfWorld()
        {
            base.InnerQuery.AddField("includeRestOfWorld");
            return this;
        }

        public PriceRuleShippingLineEntitlementsQueryBuilder TargetAllShippingLines()
        {
            base.InnerQuery.AddField("targetAllShippingLines");
            return this;
        }
    }
}