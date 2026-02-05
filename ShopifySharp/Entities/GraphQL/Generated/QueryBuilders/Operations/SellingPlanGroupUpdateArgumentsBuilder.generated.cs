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
    public sealed class SellingPlanGroupUpdateArgumentsBuilder : ArgumentsBuilderBase<SellingPlanGroupUpdatePayload, SellingPlanGroupUpdateArgumentsBuilder>
    {
        protected override SellingPlanGroupUpdateArgumentsBuilder Self => this;

        public SellingPlanGroupUpdateArgumentsBuilder(IQuery<SellingPlanGroupUpdatePayload> query) : base(query)
        {
        }

        public SellingPlanGroupUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public SellingPlanGroupUpdateArgumentsBuilder Input(SellingPlanGroupInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}