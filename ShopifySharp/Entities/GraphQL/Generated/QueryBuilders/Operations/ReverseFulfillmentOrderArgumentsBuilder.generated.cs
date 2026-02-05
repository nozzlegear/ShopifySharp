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
    public sealed class ReverseFulfillmentOrderArgumentsBuilder : ArgumentsBuilderBase<ReverseFulfillmentOrder, ReverseFulfillmentOrderArgumentsBuilder>
    {
        protected override ReverseFulfillmentOrderArgumentsBuilder Self => this;

        public ReverseFulfillmentOrderArgumentsBuilder(IQuery<ReverseFulfillmentOrder> query) : base(query)
        {
        }

        public ReverseFulfillmentOrderArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}