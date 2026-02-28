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
    public sealed class WebhookSubscriptionsArgumentsBuilder : ArgumentsBuilderBase<WebhookSubscriptionConnection, WebhookSubscriptionsArgumentsBuilder>
    {
        protected override WebhookSubscriptionsArgumentsBuilder Self => this;

        public WebhookSubscriptionsArgumentsBuilder(IQuery<WebhookSubscriptionConnection> query) : base(query)
        {
        }

        public WebhookSubscriptionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public WebhookSubscriptionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public WebhookSubscriptionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public WebhookSubscriptionsArgumentsBuilder Format(WebhookSubscriptionFormat? format)
        {
            base.InnerQuery.AddArgument("format", format);
            return this;
        }

        public WebhookSubscriptionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public WebhookSubscriptionsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public WebhookSubscriptionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public WebhookSubscriptionsArgumentsBuilder SortKey(WebhookSubscriptionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public WebhookSubscriptionsArgumentsBuilder Topics(ICollection<WebhookSubscriptionTopic>? topics)
        {
            base.InnerQuery.AddArgument("topics", topics);
            return this;
        }

        public WebhookSubscriptionsArgumentsBuilder Uri(string? uri)
        {
            base.InnerQuery.AddArgument("uri", uri);
            return this;
        }
    }
}