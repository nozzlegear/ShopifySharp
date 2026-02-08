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
    public sealed class SellingPlanGroupAddProductVariantsArgumentsBuilder : ArgumentsBuilderBase<SellingPlanGroupAddProductVariantsPayload, SellingPlanGroupAddProductVariantsArgumentsBuilder>
    {
        protected override SellingPlanGroupAddProductVariantsArgumentsBuilder Self => this;

        public SellingPlanGroupAddProductVariantsArgumentsBuilder(IQuery<SellingPlanGroupAddProductVariantsPayload> query) : base(query)
        {
        }

        public SellingPlanGroupAddProductVariantsArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public SellingPlanGroupAddProductVariantsArgumentsBuilder ProductVariantIds(ICollection<string>? productVariantIds)
        {
            base.InnerQuery.AddArgument("productVariantIds", productVariantIds);
            return this;
        }
    }
}