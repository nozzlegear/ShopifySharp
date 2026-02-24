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
    public sealed class QueryRootDisputeArgumentsBuilder : ArgumentsBuilderBase<ShopifyPaymentsDispute?, QueryRootDisputeArgumentsBuilder>
    {
        protected override QueryRootDisputeArgumentsBuilder Self => this;

        public QueryRootDisputeArgumentsBuilder(IQuery<ShopifyPaymentsDispute?> query) : base(query)
        {
        }

        public QueryRootDisputeArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}