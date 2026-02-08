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
    public sealed class DraftOrderAvailableDeliveryOptionsArgumentsBuilder : ArgumentsBuilderBase<DraftOrderAvailableDeliveryOptions, DraftOrderAvailableDeliveryOptionsArgumentsBuilder>
    {
        protected override DraftOrderAvailableDeliveryOptionsArgumentsBuilder Self => this;

        public DraftOrderAvailableDeliveryOptionsArgumentsBuilder(IQuery<DraftOrderAvailableDeliveryOptions> query) : base(query)
        {
        }

        public DraftOrderAvailableDeliveryOptionsArgumentsBuilder Input(DraftOrderAvailableDeliveryOptionsInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }

        public DraftOrderAvailableDeliveryOptionsArgumentsBuilder LocalPickupCount(int? localPickupCount)
        {
            base.InnerQuery.AddArgument("localPickupCount", localPickupCount);
            return this;
        }

        public DraftOrderAvailableDeliveryOptionsArgumentsBuilder LocalPickupFrom(int? localPickupFrom)
        {
            base.InnerQuery.AddArgument("localPickupFrom", localPickupFrom);
            return this;
        }

        public DraftOrderAvailableDeliveryOptionsArgumentsBuilder Search(string? search)
        {
            base.InnerQuery.AddArgument("search", search);
            return this;
        }

        public DraftOrderAvailableDeliveryOptionsArgumentsBuilder SessionToken(string? sessionToken)
        {
            base.InnerQuery.AddArgument("sessionToken", sessionToken);
            return this;
        }
    }
}