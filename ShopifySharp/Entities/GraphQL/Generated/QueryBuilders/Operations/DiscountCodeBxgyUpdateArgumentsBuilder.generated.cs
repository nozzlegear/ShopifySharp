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
    public sealed class DiscountCodeBxgyUpdateArgumentsBuilder : ArgumentsBuilderBase<DiscountCodeBxgyUpdatePayload, DiscountCodeBxgyUpdateArgumentsBuilder>
    {
        protected override DiscountCodeBxgyUpdateArgumentsBuilder Self => this;

        public DiscountCodeBxgyUpdateArgumentsBuilder(IQuery<DiscountCodeBxgyUpdatePayload> query) : base(query)
        {
        }

        public DiscountCodeBxgyUpdateArgumentsBuilder BxgyCodeDiscount(DiscountCodeBxgyInput? bxgyCodeDiscount)
        {
            base.InnerQuery.AddArgument("bxgyCodeDiscount", bxgyCodeDiscount);
            return this;
        }

        public DiscountCodeBxgyUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}