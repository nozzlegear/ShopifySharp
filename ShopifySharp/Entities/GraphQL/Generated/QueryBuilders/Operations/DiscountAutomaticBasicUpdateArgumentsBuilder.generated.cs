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