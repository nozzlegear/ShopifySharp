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
    public sealed class ProductVariantLeaveSellingPlanGroupsArgumentsBuilder : ArgumentsBuilderBase<ProductVariantLeaveSellingPlanGroupsPayload, ProductVariantLeaveSellingPlanGroupsArgumentsBuilder>
    {
        protected override ProductVariantLeaveSellingPlanGroupsArgumentsBuilder Self => this;

        public ProductVariantLeaveSellingPlanGroupsArgumentsBuilder(IQuery<ProductVariantLeaveSellingPlanGroupsPayload> query) : base(query)
        {
        }

        public ProductVariantLeaveSellingPlanGroupsArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public ProductVariantLeaveSellingPlanGroupsArgumentsBuilder SellingPlanGroupIds(ICollection<string>? sellingPlanGroupIds)
        {
            base.InnerQuery.AddArgument("sellingPlanGroupIds", sellingPlanGroupIds);
            return this;
        }
    }
}