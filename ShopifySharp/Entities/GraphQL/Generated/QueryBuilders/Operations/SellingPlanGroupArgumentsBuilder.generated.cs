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
    public sealed class SellingPlanGroupArgumentsBuilder : ArgumentsBuilderBase<SellingPlanGroup, SellingPlanGroupArgumentsBuilder>
    {
        protected override SellingPlanGroupArgumentsBuilder Self => this;

        public SellingPlanGroupArgumentsBuilder(IQuery<SellingPlanGroup> query) : base(query)
        {
        }

        public SellingPlanGroupArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}