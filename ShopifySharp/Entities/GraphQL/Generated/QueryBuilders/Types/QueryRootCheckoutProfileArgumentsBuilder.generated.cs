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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootCheckoutProfileArgumentsBuilder : ArgumentsBuilderBase<CheckoutProfile?, QueryRootCheckoutProfileArgumentsBuilder>
    {
        protected override QueryRootCheckoutProfileArgumentsBuilder Self => this;

        public QueryRootCheckoutProfileArgumentsBuilder(IQuery<CheckoutProfile?> query) : base(query)
        {
        }

        public QueryRootCheckoutProfileArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}