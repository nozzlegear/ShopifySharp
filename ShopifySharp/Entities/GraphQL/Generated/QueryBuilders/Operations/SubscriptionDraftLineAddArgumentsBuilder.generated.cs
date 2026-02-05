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
    public sealed class SubscriptionDraftLineAddArgumentsBuilder : ArgumentsBuilderBase<SubscriptionDraftLineAddPayload, SubscriptionDraftLineAddArgumentsBuilder>
    {
        protected override SubscriptionDraftLineAddArgumentsBuilder Self => this;

        public SubscriptionDraftLineAddArgumentsBuilder(IQuery<SubscriptionDraftLineAddPayload> query) : base(query)
        {
        }

        public SubscriptionDraftLineAddArgumentsBuilder DraftId(string? draftId)
        {
            base.InnerQuery.AddArgument("draftId", draftId);
            return this;
        }

        public SubscriptionDraftLineAddArgumentsBuilder Input(SubscriptionLineInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}