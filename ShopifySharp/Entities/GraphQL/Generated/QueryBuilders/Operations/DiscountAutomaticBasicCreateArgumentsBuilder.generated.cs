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
    public sealed class DiscountAutomaticBasicCreateArgumentsBuilder : ArgumentsBuilderBase<DiscountAutomaticBasicCreatePayload, DiscountAutomaticBasicCreateArgumentsBuilder>
    {
        protected override DiscountAutomaticBasicCreateArgumentsBuilder Self => this;

        public DiscountAutomaticBasicCreateArgumentsBuilder(IQuery<DiscountAutomaticBasicCreatePayload> query) : base(query)
        {
        }

        public DiscountAutomaticBasicCreateArgumentsBuilder AutomaticBasicDiscount(DiscountAutomaticBasicInput? automaticBasicDiscount)
        {
            base.InnerQuery.AddArgument("automaticBasicDiscount", automaticBasicDiscount);
            return this;
        }
    }
}