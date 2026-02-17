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
    public sealed class RemoveFromReturnArgumentsBuilder : ArgumentsBuilderBase<RemoveFromReturnPayload, RemoveFromReturnArgumentsBuilder>
    {
        protected override RemoveFromReturnArgumentsBuilder Self => this;

        public RemoveFromReturnArgumentsBuilder(IQuery<RemoveFromReturnPayload> query) : base(query)
        {
        }

        public RemoveFromReturnArgumentsBuilder ExchangeLineItems(ICollection<ExchangeLineItemRemoveFromReturnInput>? exchangeLineItems)
        {
            base.InnerQuery.AddArgument("exchangeLineItems", exchangeLineItems);
            return this;
        }

        public RemoveFromReturnArgumentsBuilder ReturnId(string? returnId)
        {
            base.InnerQuery.AddArgument("returnId", returnId);
            return this;
        }

        public RemoveFromReturnArgumentsBuilder ReturnLineItems(ICollection<ReturnLineItemRemoveFromReturnInput>? returnLineItems)
        {
            base.InnerQuery.AddArgument("returnLineItems", returnLineItems);
            return this;
        }
    }
}