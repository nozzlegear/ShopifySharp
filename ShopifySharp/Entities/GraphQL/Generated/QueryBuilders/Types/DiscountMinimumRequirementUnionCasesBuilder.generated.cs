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
    public sealed class DiscountMinimumRequirementUnionCasesBuilder : UnionCasesBuilderBase<DiscountMinimumRequirement, DiscountMinimumRequirementUnionCasesBuilder>
    {
        protected override DiscountMinimumRequirementUnionCasesBuilder Self => this;

        public DiscountMinimumRequirementUnionCasesBuilder(string fieldName = "discountMinimumRequirement") : this(new Query<DiscountMinimumRequirement>(fieldName))
        {
        }

        public DiscountMinimumRequirementUnionCasesBuilder(IQuery<DiscountMinimumRequirement> query) : base(query)
        {
        }

        public DiscountMinimumRequirementUnionCasesBuilder OnDiscountMinimumQuantity(Action<DiscountMinimumQuantityQueryBuilder> build)
        {
            var query = new Query<DiscountMinimumQuantity>("... on DiscountMinimumQuantity");
            var queryBuilder = new DiscountMinimumQuantityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public DiscountMinimumRequirementUnionCasesBuilder OnDiscountMinimumSubtotal(Action<DiscountMinimumSubtotalQueryBuilder> build)
        {
            var query = new Query<DiscountMinimumSubtotal>("... on DiscountMinimumSubtotal");
            var queryBuilder = new DiscountMinimumSubtotalQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}