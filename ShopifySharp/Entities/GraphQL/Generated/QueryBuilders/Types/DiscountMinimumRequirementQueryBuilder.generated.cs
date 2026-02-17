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
    public sealed class DiscountMinimumRequirementQueryBuilder : FieldsQueryBuilderBase<DiscountMinimumRequirement, DiscountMinimumRequirementQueryBuilder>
    {
        protected override DiscountMinimumRequirementQueryBuilder Self => this;

        public DiscountMinimumRequirementQueryBuilder() : this("discountMinimumRequirement")
        {
        }

        public DiscountMinimumRequirementQueryBuilder(string name) : base(new Query<DiscountMinimumRequirement>(name))
        {
        }

        public DiscountMinimumRequirementQueryBuilder(IQuery<DiscountMinimumRequirement> query) : base(query)
        {
        }

        public DiscountMinimumRequirementQueryBuilder DiscountMinimumRequirement(Action<DiscountMinimumRequirementUnionCasesBuilder> build)
        {
            var query = new Query<DiscountMinimumRequirement>("discountMinimumRequirement");
            var unionBuilder = new DiscountMinimumRequirementUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}