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
    public sealed class AppSubscriptionQueryBuilder : FieldsQueryBuilderBase<AppSubscription, AppSubscriptionQueryBuilder>
    {
        protected override AppSubscriptionQueryBuilder Self => this;

        public AppSubscriptionQueryBuilder() : this("appSubscription")
        {
        }

        public AppSubscriptionQueryBuilder(string name) : base(new Query<AppSubscription>(name))
        {
        }

        public AppSubscriptionQueryBuilder(IQuery<AppSubscription> query) : base(query)
        {
        }

        public AppSubscriptionQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public AppSubscriptionQueryBuilder CurrentPeriodEnd()
        {
            base.InnerQuery.AddField("currentPeriodEnd");
            return this;
        }

        public AppSubscriptionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AppSubscriptionQueryBuilder LineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionLineItemQueryBuilder> build)
        {
            var query = new Query<AppSubscriptionLineItem>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscriptionLineItem>(query);
            return this;
        }

        public AppSubscriptionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public AppSubscriptionQueryBuilder ReturnUrl()
        {
            base.InnerQuery.AddField("returnUrl");
            return this;
        }

        public AppSubscriptionQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public AppSubscriptionQueryBuilder Test()
        {
            base.InnerQuery.AddField("test");
            return this;
        }

        public AppSubscriptionQueryBuilder TrialDays()
        {
            base.InnerQuery.AddField("trialDays");
            return this;
        }
    }
}