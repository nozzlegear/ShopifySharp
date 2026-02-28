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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class WebhookSubscriptionConnectionArgumentsBuilder : ArgumentsBuilderBase<WebhookSubscriptionConnection, WebhookSubscriptionConnectionArgumentsBuilder>
    {
        protected override WebhookSubscriptionConnectionArgumentsBuilder Self => this;

        public WebhookSubscriptionConnectionArgumentsBuilder(IQuery<WebhookSubscriptionConnection> query) : base(query)
        {
        }

        public WebhookSubscriptionConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public WebhookSubscriptionConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public WebhookSubscriptionConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public WebhookSubscriptionConnectionArgumentsBuilder Format(WebhookSubscriptionFormat? format)
        {
            base.InnerQuery.AddArgument("format", format);
            return this;
        }

        public WebhookSubscriptionConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public WebhookSubscriptionConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public WebhookSubscriptionConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public WebhookSubscriptionConnectionArgumentsBuilder SortKey(WebhookSubscriptionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public WebhookSubscriptionConnectionArgumentsBuilder Topics(ICollection<WebhookSubscriptionTopic>? topics)
        {
            base.InnerQuery.AddArgument("topics", topics);
            return this;
        }

        public WebhookSubscriptionConnectionArgumentsBuilder Uri(string? uri)
        {
            base.InnerQuery.AddArgument("uri", uri);
            return this;
        }
    }
}