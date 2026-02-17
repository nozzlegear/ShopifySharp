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
    public sealed class DiscountAutomaticDeleteArgumentsBuilder : ArgumentsBuilderBase<DiscountAutomaticDeletePayload, DiscountAutomaticDeleteArgumentsBuilder>
    {
        protected override DiscountAutomaticDeleteArgumentsBuilder Self => this;

        public DiscountAutomaticDeleteArgumentsBuilder(IQuery<DiscountAutomaticDeletePayload> query) : base(query)
        {
        }

        public DiscountAutomaticDeleteArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}