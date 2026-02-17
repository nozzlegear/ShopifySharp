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