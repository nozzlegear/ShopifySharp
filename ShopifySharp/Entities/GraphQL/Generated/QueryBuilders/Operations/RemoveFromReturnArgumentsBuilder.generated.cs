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