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
    public sealed class SubscriptionDraftUpdateArgumentsBuilder : ArgumentsBuilderBase<SubscriptionDraftUpdatePayload, SubscriptionDraftUpdateArgumentsBuilder>
    {
        protected override SubscriptionDraftUpdateArgumentsBuilder Self => this;

        public SubscriptionDraftUpdateArgumentsBuilder(IQuery<SubscriptionDraftUpdatePayload> query) : base(query)
        {
        }

        public SubscriptionDraftUpdateArgumentsBuilder DraftId(string? draftId)
        {
            base.InnerQuery.AddArgument("draftId", draftId);
            return this;
        }

        public SubscriptionDraftUpdateArgumentsBuilder Input(SubscriptionDraftInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}