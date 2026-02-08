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
    public sealed class SellingPlanGroupRemoveProductVariantsArgumentsBuilder : ArgumentsBuilderBase<SellingPlanGroupRemoveProductVariantsPayload, SellingPlanGroupRemoveProductVariantsArgumentsBuilder>
    {
        protected override SellingPlanGroupRemoveProductVariantsArgumentsBuilder Self => this;

        public SellingPlanGroupRemoveProductVariantsArgumentsBuilder(IQuery<SellingPlanGroupRemoveProductVariantsPayload> query) : base(query)
        {
        }

        public SellingPlanGroupRemoveProductVariantsArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public SellingPlanGroupRemoveProductVariantsArgumentsBuilder ProductVariantIds(ICollection<string>? productVariantIds)
        {
            base.InnerQuery.AddArgument("productVariantIds", productVariantIds);
            return this;
        }
    }
}