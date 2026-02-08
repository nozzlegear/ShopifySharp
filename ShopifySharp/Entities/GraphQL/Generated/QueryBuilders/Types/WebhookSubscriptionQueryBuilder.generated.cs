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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class WebhookSubscriptionQueryBuilder : FieldsQueryBuilderBase<WebhookSubscription, WebhookSubscriptionQueryBuilder>
    {
        protected override WebhookSubscriptionQueryBuilder Self => this;

        public WebhookSubscriptionQueryBuilder() : this("webhookSubscription")
        {
        }

        public WebhookSubscriptionQueryBuilder(string name) : base(new Query<WebhookSubscription>(name))
        {
        }

        public WebhookSubscriptionQueryBuilder(IQuery<WebhookSubscription> query) : base(query)
        {
        }

        public WebhookSubscriptionQueryBuilder ApiVersion(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ApiVersionQueryBuilder> build)
        {
            var query = new Query<ApiVersion>("apiVersion");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ApiVersionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ApiVersion>(query);
            return this;
        }

        [Obsolete("Use `uri` instead.")]
        public WebhookSubscriptionQueryBuilder CallbackUrl()
        {
            base.InnerQuery.AddField("callbackUrl");
            return this;
        }

        public WebhookSubscriptionQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public WebhookSubscriptionQueryBuilder Filter()
        {
            base.InnerQuery.AddField("filter");
            return this;
        }

        public WebhookSubscriptionQueryBuilder Format()
        {
            base.InnerQuery.AddField("format");
            return this;
        }

        public WebhookSubscriptionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public WebhookSubscriptionQueryBuilder IncludeFields()
        {
            base.InnerQuery.AddField("includeFields");
            return this;
        }

        public WebhookSubscriptionQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public WebhookSubscriptionQueryBuilder MetafieldNamespaces()
        {
            base.InnerQuery.AddField("metafieldNamespaces");
            return this;
        }

        public WebhookSubscriptionQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionMetafieldIdentifierQueryBuilder> build)
        {
            var query = new Query<WebhookSubscriptionMetafieldIdentifier>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionMetafieldIdentifierQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscriptionMetafieldIdentifier>(query);
            return this;
        }

        public WebhookSubscriptionQueryBuilder Topic()
        {
            base.InnerQuery.AddField("topic");
            return this;
        }

        public WebhookSubscriptionQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public WebhookSubscriptionQueryBuilder Uri()
        {
            base.InnerQuery.AddField("uri");
            return this;
        }

        [Obsolete("Use `uri` instead.")]
        public WebhookSubscriptionQueryBuilder Endpoint(Action<WebhookSubscriptionEndpointUnionCasesBuilder> build)
        {
            var query = new Query<WebhookSubscriptionEndpoint>("endpoint");
            var unionBuilder = new WebhookSubscriptionEndpointUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}