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
    public sealed class ProductVariantJoinSellingPlanGroupsArgumentsBuilder : ArgumentsBuilderBase<ProductVariantJoinSellingPlanGroupsPayload, ProductVariantJoinSellingPlanGroupsArgumentsBuilder>
    {
        protected override ProductVariantJoinSellingPlanGroupsArgumentsBuilder Self => this;

        public ProductVariantJoinSellingPlanGroupsArgumentsBuilder(IQuery<ProductVariantJoinSellingPlanGroupsPayload> query) : base(query)
        {
        }

        public ProductVariantJoinSellingPlanGroupsArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public ProductVariantJoinSellingPlanGroupsArgumentsBuilder SellingPlanGroupIds(ICollection<string>? sellingPlanGroupIds)
        {
            base.InnerQuery.AddArgument("sellingPlanGroupIds", sellingPlanGroupIds);
            return this;
        }
    }
}