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
    public sealed class DiscountAutomaticBxgyCreateArgumentsBuilder : ArgumentsBuilderBase<DiscountAutomaticBxgyCreatePayload, DiscountAutomaticBxgyCreateArgumentsBuilder>
    {
        protected override DiscountAutomaticBxgyCreateArgumentsBuilder Self => this;

        public DiscountAutomaticBxgyCreateArgumentsBuilder(IQuery<DiscountAutomaticBxgyCreatePayload> query) : base(query)
        {
        }

        public DiscountAutomaticBxgyCreateArgumentsBuilder AutomaticBxgyDiscount(DiscountAutomaticBxgyInput? automaticBxgyDiscount)
        {
            base.InnerQuery.AddArgument("automaticBxgyDiscount", automaticBxgyDiscount);
            return this;
        }
    }
}