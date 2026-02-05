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
    public sealed class SellingPlanGroupRemoveProductsArgumentsBuilder : ArgumentsBuilderBase<SellingPlanGroupRemoveProductsPayload, SellingPlanGroupRemoveProductsArgumentsBuilder>
    {
        protected override SellingPlanGroupRemoveProductsArgumentsBuilder Self => this;

        public SellingPlanGroupRemoveProductsArgumentsBuilder(IQuery<SellingPlanGroupRemoveProductsPayload> query) : base(query)
        {
        }

        public SellingPlanGroupRemoveProductsArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public SellingPlanGroupRemoveProductsArgumentsBuilder ProductIds(ICollection<string>? productIds)
        {
            base.InnerQuery.AddArgument("productIds", productIds);
            return this;
        }
    }
}