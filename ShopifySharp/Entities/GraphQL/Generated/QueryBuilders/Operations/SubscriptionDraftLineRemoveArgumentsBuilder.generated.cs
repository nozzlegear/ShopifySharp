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
    public sealed class SubscriptionDraftLineRemoveArgumentsBuilder : ArgumentsBuilderBase<SubscriptionDraftLineRemovePayload, SubscriptionDraftLineRemoveArgumentsBuilder>
    {
        protected override SubscriptionDraftLineRemoveArgumentsBuilder Self => this;

        public SubscriptionDraftLineRemoveArgumentsBuilder(IQuery<SubscriptionDraftLineRemovePayload> query) : base(query)
        {
        }

        public SubscriptionDraftLineRemoveArgumentsBuilder DraftId(string? draftId)
        {
            base.InnerQuery.AddArgument("draftId", draftId);
            return this;
        }

        public SubscriptionDraftLineRemoveArgumentsBuilder LineId(string? lineId)
        {
            base.InnerQuery.AddArgument("lineId", lineId);
            return this;
        }
    }
}