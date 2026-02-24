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
    public sealed class QueryRootWebhookSubscriptionsArgumentsBuilder : ArgumentsBuilderBase<WebhookSubscriptionConnection?, QueryRootWebhookSubscriptionsArgumentsBuilder>
    {
        protected override QueryRootWebhookSubscriptionsArgumentsBuilder Self => this;

        public QueryRootWebhookSubscriptionsArgumentsBuilder(IQuery<WebhookSubscriptionConnection?> query) : base(query)
        {
        }

        public QueryRootWebhookSubscriptionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootWebhookSubscriptionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootWebhookSubscriptionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootWebhookSubscriptionsArgumentsBuilder Format(WebhookSubscriptionFormat? format)
        {
            base.InnerQuery.AddArgument("format", format);
            return this;
        }

        public QueryRootWebhookSubscriptionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootWebhookSubscriptionsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public QueryRootWebhookSubscriptionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public QueryRootWebhookSubscriptionsArgumentsBuilder SortKey(WebhookSubscriptionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public QueryRootWebhookSubscriptionsArgumentsBuilder Topics(ICollection<WebhookSubscriptionTopic>? topics)
        {
            base.InnerQuery.AddArgument("topics", topics);
            return this;
        }
    }
}