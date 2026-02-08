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
    public sealed class DiscountAutomaticBxgyUpdateArgumentsBuilder : ArgumentsBuilderBase<DiscountAutomaticBxgyUpdatePayload, DiscountAutomaticBxgyUpdateArgumentsBuilder>
    {
        protected override DiscountAutomaticBxgyUpdateArgumentsBuilder Self => this;

        public DiscountAutomaticBxgyUpdateArgumentsBuilder(IQuery<DiscountAutomaticBxgyUpdatePayload> query) : base(query)
        {
        }

        public DiscountAutomaticBxgyUpdateArgumentsBuilder AutomaticBxgyDiscount(DiscountAutomaticBxgyInput? automaticBxgyDiscount)
        {
            base.InnerQuery.AddArgument("automaticBxgyDiscount", automaticBxgyDiscount);
            return this;
        }

        public DiscountAutomaticBxgyUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}