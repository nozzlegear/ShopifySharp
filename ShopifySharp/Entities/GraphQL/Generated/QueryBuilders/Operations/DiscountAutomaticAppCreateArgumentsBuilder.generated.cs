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
    public sealed class DiscountAutomaticAppCreateArgumentsBuilder : ArgumentsBuilderBase<DiscountAutomaticAppCreatePayload, DiscountAutomaticAppCreateArgumentsBuilder>
    {
        protected override DiscountAutomaticAppCreateArgumentsBuilder Self => this;

        public DiscountAutomaticAppCreateArgumentsBuilder(IQuery<DiscountAutomaticAppCreatePayload> query) : base(query)
        {
        }

        public DiscountAutomaticAppCreateArgumentsBuilder AutomaticAppDiscount(DiscountAutomaticAppInput? automaticAppDiscount)
        {
            base.InnerQuery.AddArgument("automaticAppDiscount", automaticAppDiscount);
            return this;
        }
    }
}