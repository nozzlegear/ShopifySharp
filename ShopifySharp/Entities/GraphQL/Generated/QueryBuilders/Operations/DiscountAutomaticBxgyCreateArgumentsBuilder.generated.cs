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