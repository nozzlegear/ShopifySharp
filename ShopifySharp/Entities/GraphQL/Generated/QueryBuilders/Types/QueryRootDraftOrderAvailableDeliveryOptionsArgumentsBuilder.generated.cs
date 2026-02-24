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
    public sealed class QueryRootDraftOrderAvailableDeliveryOptionsArgumentsBuilder : ArgumentsBuilderBase<DraftOrderAvailableDeliveryOptions?, QueryRootDraftOrderAvailableDeliveryOptionsArgumentsBuilder>
    {
        protected override QueryRootDraftOrderAvailableDeliveryOptionsArgumentsBuilder Self => this;

        public QueryRootDraftOrderAvailableDeliveryOptionsArgumentsBuilder(IQuery<DraftOrderAvailableDeliveryOptions?> query) : base(query)
        {
        }

        public QueryRootDraftOrderAvailableDeliveryOptionsArgumentsBuilder Input(DraftOrderAvailableDeliveryOptionsInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }

        public QueryRootDraftOrderAvailableDeliveryOptionsArgumentsBuilder LocalPickupCount(int? localPickupCount)
        {
            base.InnerQuery.AddArgument("localPickupCount", localPickupCount);
            return this;
        }

        public QueryRootDraftOrderAvailableDeliveryOptionsArgumentsBuilder LocalPickupFrom(int? localPickupFrom)
        {
            base.InnerQuery.AddArgument("localPickupFrom", localPickupFrom);
            return this;
        }

        public QueryRootDraftOrderAvailableDeliveryOptionsArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }

        public QueryRootDraftOrderAvailableDeliveryOptionsArgumentsBuilder SessionToken(string? sessionToken)
        {
            base.InnerQuery.AddArgument("sessionToken", sessionToken);
            return this;
        }
    }
}