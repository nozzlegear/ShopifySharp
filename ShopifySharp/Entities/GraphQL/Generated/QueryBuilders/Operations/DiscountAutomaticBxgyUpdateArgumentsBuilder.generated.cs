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