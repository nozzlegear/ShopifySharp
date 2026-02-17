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
    public sealed class SubscriptionDeliveryMethodQueryBuilder : FieldsQueryBuilderBase<SubscriptionDeliveryMethod, SubscriptionDeliveryMethodQueryBuilder>
    {
        protected override SubscriptionDeliveryMethodQueryBuilder Self => this;

        public SubscriptionDeliveryMethodQueryBuilder() : this("subscriptionDeliveryMethod")
        {
        }

        public SubscriptionDeliveryMethodQueryBuilder(string name) : base(new Query<SubscriptionDeliveryMethod>(name))
        {
        }

        public SubscriptionDeliveryMethodQueryBuilder(IQuery<SubscriptionDeliveryMethod> query) : base(query)
        {
        }

        public SubscriptionDeliveryMethodQueryBuilder SubscriptionDeliveryMethod(Action<SubscriptionDeliveryMethodUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryMethod>("subscriptionDeliveryMethod");
            var unionBuilder = new SubscriptionDeliveryMethodUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}