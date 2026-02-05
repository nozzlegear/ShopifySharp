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
    public sealed class SubscriptionDraftCommitArgumentsBuilder : ArgumentsBuilderBase<SubscriptionDraftCommitPayload, SubscriptionDraftCommitArgumentsBuilder>
    {
        protected override SubscriptionDraftCommitArgumentsBuilder Self => this;

        public SubscriptionDraftCommitArgumentsBuilder(IQuery<SubscriptionDraftCommitPayload> query) : base(query)
        {
        }

        public SubscriptionDraftCommitArgumentsBuilder DraftId(string? draftId)
        {
            base.InnerQuery.AddArgument("draftId", draftId);
            return this;
        }
    }
}