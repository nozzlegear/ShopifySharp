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
    public sealed class QueryRootWebhookSubscriptionQueryBuilder : FieldsQueryBuilderBase<WebhookSubscription, QueryRootWebhookSubscriptionQueryBuilder>, IHasArguments<QueryRootWebhookSubscriptionArgumentsBuilder>
    {
        public QueryRootWebhookSubscriptionArgumentsBuilder Arguments { get; }
        protected override QueryRootWebhookSubscriptionQueryBuilder Self => this;

        public QueryRootWebhookSubscriptionQueryBuilder(string name) : base(new Query<WebhookSubscription>(name))
        {
            Arguments = new QueryRootWebhookSubscriptionArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootWebhookSubscriptionQueryBuilder(IQuery<WebhookSubscription> query) : base(query)
        {
            Arguments = new QueryRootWebhookSubscriptionArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootWebhookSubscriptionQueryBuilder SetArguments(Action<QueryRootWebhookSubscriptionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootWebhookSubscriptionQueryBuilder ApiVersion(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ApiVersionQueryBuilder> build)
        {
            var query = new Query<ApiVersion>("apiVersion");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ApiVersionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ApiVersion>(query);
            return this;
        }

        [Obsolete("Use `uri` instead.")]
        public QueryRootWebhookSubscriptionQueryBuilder CallbackUrl()
        {
            base.InnerQuery.AddField("callbackUrl");
            return this;
        }

        public QueryRootWebhookSubscriptionQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootWebhookSubscriptionQueryBuilder Filter()
        {
            base.InnerQuery.AddField("filter");
            return this;
        }

        public QueryRootWebhookSubscriptionQueryBuilder Format()
        {
            base.InnerQuery.AddField("format");
            return this;
        }

        public QueryRootWebhookSubscriptionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootWebhookSubscriptionQueryBuilder IncludeFields()
        {
            base.InnerQuery.AddField("includeFields");
            return this;
        }

        public QueryRootWebhookSubscriptionQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public QueryRootWebhookSubscriptionQueryBuilder MetafieldNamespaces()
        {
            base.InnerQuery.AddField("metafieldNamespaces");
            return this;
        }

        public QueryRootWebhookSubscriptionQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionMetafieldIdentifierQueryBuilder> build)
        {
            var query = new Query<WebhookSubscriptionMetafieldIdentifier>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionMetafieldIdentifierQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscriptionMetafieldIdentifier>(query);
            return this;
        }

        public QueryRootWebhookSubscriptionQueryBuilder Topic()
        {
            base.InnerQuery.AddField("topic");
            return this;
        }

        public QueryRootWebhookSubscriptionQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        [Obsolete("Use `uri` instead.")]
        public QueryRootWebhookSubscriptionQueryBuilder Endpoint(Action<WebhookSubscriptionEndpointUnionCasesBuilder> build)
        {
            var query = new Query<WebhookSubscriptionEndpoint>("endpoint");
            var unionBuilder = new WebhookSubscriptionEndpointUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}