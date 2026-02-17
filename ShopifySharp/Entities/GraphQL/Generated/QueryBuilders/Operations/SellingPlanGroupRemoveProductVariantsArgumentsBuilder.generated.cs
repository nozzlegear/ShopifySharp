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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
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