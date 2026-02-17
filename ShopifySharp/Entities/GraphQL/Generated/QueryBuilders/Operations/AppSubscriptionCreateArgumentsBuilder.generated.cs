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
    public sealed class AppSubscriptionCreateArgumentsBuilder : ArgumentsBuilderBase<AppSubscriptionCreatePayload, AppSubscriptionCreateArgumentsBuilder>
    {
        protected override AppSubscriptionCreateArgumentsBuilder Self => this;

        public AppSubscriptionCreateArgumentsBuilder(IQuery<AppSubscriptionCreatePayload> query) : base(query)
        {
        }

        public AppSubscriptionCreateArgumentsBuilder LineItems(ICollection<AppSubscriptionLineItemInput>? lineItems)
        {
            base.InnerQuery.AddArgument("lineItems", lineItems);
            return this;
        }

        public AppSubscriptionCreateArgumentsBuilder Name(string? name)
        {
            base.InnerQuery.AddArgument("name", name);
            return this;
        }

        public AppSubscriptionCreateArgumentsBuilder ReplacementBehavior(AppSubscriptionReplacementBehavior? replacementBehavior)
        {
            base.InnerQuery.AddArgument("replacementBehavior", replacementBehavior);
            return this;
        }

        public AppSubscriptionCreateArgumentsBuilder ReturnUrl(string? returnUrl)
        {
            base.InnerQuery.AddArgument("returnUrl", returnUrl);
            return this;
        }

        public AppSubscriptionCreateArgumentsBuilder Test(bool? test)
        {
            base.InnerQuery.AddArgument("test", test);
            return this;
        }

        public AppSubscriptionCreateArgumentsBuilder TrialDays(int? trialDays)
        {
            base.InnerQuery.AddArgument("trialDays", trialDays);
            return this;
        }
    }
}