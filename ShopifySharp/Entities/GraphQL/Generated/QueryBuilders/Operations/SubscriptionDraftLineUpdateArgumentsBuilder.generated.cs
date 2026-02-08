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
    public sealed class SubscriptionDraftLineUpdateArgumentsBuilder : ArgumentsBuilderBase<SubscriptionDraftLineUpdatePayload, SubscriptionDraftLineUpdateArgumentsBuilder>
    {
        protected override SubscriptionDraftLineUpdateArgumentsBuilder Self => this;

        public SubscriptionDraftLineUpdateArgumentsBuilder(IQuery<SubscriptionDraftLineUpdatePayload> query) : base(query)
        {
        }

        public SubscriptionDraftLineUpdateArgumentsBuilder DraftId(string? draftId)
        {
            base.InnerQuery.AddArgument("draftId", draftId);
            return this;
        }

        public SubscriptionDraftLineUpdateArgumentsBuilder Input(SubscriptionLineUpdateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }

        public SubscriptionDraftLineUpdateArgumentsBuilder LineId(string? lineId)
        {
            base.InnerQuery.AddArgument("lineId", lineId);
            return this;
        }
    }
}