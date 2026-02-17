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
    public sealed class CheckoutProfileArgumentsBuilder : ArgumentsBuilderBase<CheckoutProfile, CheckoutProfileArgumentsBuilder>
    {
        protected override CheckoutProfileArgumentsBuilder Self => this;

        public CheckoutProfileArgumentsBuilder(IQuery<CheckoutProfile> query) : base(query)
        {
        }

        public CheckoutProfileArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}