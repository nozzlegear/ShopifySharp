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