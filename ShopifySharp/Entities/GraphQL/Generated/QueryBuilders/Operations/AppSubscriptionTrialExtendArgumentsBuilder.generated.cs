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
    public sealed class AppSubscriptionTrialExtendArgumentsBuilder : ArgumentsBuilderBase<AppSubscriptionTrialExtendPayload, AppSubscriptionTrialExtendArgumentsBuilder>
    {
        protected override AppSubscriptionTrialExtendArgumentsBuilder Self => this;

        public AppSubscriptionTrialExtendArgumentsBuilder(IQuery<AppSubscriptionTrialExtendPayload> query) : base(query)
        {
        }

        public AppSubscriptionTrialExtendArgumentsBuilder Days(int? days)
        {
            base.InnerQuery.AddArgument("days", days);
            return this;
        }

        public AppSubscriptionTrialExtendArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}