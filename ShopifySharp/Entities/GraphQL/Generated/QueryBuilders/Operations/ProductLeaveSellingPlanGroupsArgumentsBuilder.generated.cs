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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class ProductLeaveSellingPlanGroupsArgumentsBuilder : ArgumentsBuilderBase<ProductLeaveSellingPlanGroupsPayload, ProductLeaveSellingPlanGroupsArgumentsBuilder>
    {
        protected override ProductLeaveSellingPlanGroupsArgumentsBuilder Self => this;

        public ProductLeaveSellingPlanGroupsArgumentsBuilder(IQuery<ProductLeaveSellingPlanGroupsPayload> query) : base(query)
        {
        }

        public ProductLeaveSellingPlanGroupsArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public ProductLeaveSellingPlanGroupsArgumentsBuilder SellingPlanGroupIds(ICollection<string>? sellingPlanGroupIds)
        {
            base.InnerQuery.AddArgument("sellingPlanGroupIds", sellingPlanGroupIds);
            return this;
        }
    }
}