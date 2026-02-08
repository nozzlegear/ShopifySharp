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
    public sealed class DiscountAutomaticBasicUpdateArgumentsBuilder : ArgumentsBuilderBase<DiscountAutomaticBasicUpdatePayload, DiscountAutomaticBasicUpdateArgumentsBuilder>
    {
        protected override DiscountAutomaticBasicUpdateArgumentsBuilder Self => this;

        public DiscountAutomaticBasicUpdateArgumentsBuilder(IQuery<DiscountAutomaticBasicUpdatePayload> query) : base(query)
        {
        }

        public DiscountAutomaticBasicUpdateArgumentsBuilder AutomaticBasicDiscount(DiscountAutomaticBasicInput? automaticBasicDiscount)
        {
            base.InnerQuery.AddArgument("automaticBasicDiscount", automaticBasicDiscount);
            return this;
        }

        public DiscountAutomaticBasicUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}