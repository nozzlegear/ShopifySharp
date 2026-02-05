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
    public sealed class ReturnLineItemRemoveFromReturnArgumentsBuilder : ArgumentsBuilderBase<ReturnLineItemRemoveFromReturnPayload, ReturnLineItemRemoveFromReturnArgumentsBuilder>
    {
        protected override ReturnLineItemRemoveFromReturnArgumentsBuilder Self => this;

        public ReturnLineItemRemoveFromReturnArgumentsBuilder(IQuery<ReturnLineItemRemoveFromReturnPayload> query) : base(query)
        {
        }

        public ReturnLineItemRemoveFromReturnArgumentsBuilder ReturnId(string? returnId)
        {
            base.InnerQuery.AddArgument("returnId", returnId);
            return this;
        }

        public ReturnLineItemRemoveFromReturnArgumentsBuilder ReturnLineItems(ICollection<ReturnLineItemRemoveFromReturnInput>? returnLineItems)
        {
            base.InnerQuery.AddArgument("returnLineItems", returnLineItems);
            return this;
        }
    }
}