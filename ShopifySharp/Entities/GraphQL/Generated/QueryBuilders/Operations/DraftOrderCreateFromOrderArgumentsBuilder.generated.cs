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
    public sealed class DraftOrderCreateFromOrderArgumentsBuilder : ArgumentsBuilderBase<DraftOrderCreateFromOrderPayload, DraftOrderCreateFromOrderArgumentsBuilder>
    {
        protected override DraftOrderCreateFromOrderArgumentsBuilder Self => this;

        public DraftOrderCreateFromOrderArgumentsBuilder(IQuery<DraftOrderCreateFromOrderPayload> query) : base(query)
        {
        }

        public DraftOrderCreateFromOrderArgumentsBuilder OrderId(string? orderId)
        {
            base.InnerQuery.AddArgument("orderId", orderId);
            return this;
        }
    }
}