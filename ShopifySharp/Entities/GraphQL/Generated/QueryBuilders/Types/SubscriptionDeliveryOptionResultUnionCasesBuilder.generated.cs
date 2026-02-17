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
    public sealed class SubscriptionDeliveryOptionResultUnionCasesBuilder : UnionCasesBuilderBase<SubscriptionDeliveryOptionResult, SubscriptionDeliveryOptionResultUnionCasesBuilder>
    {
        protected override SubscriptionDeliveryOptionResultUnionCasesBuilder Self => this;

        public SubscriptionDeliveryOptionResultUnionCasesBuilder(string fieldName = "deliveryOptions") : this(new Query<SubscriptionDeliveryOptionResult>(fieldName))
        {
        }

        public SubscriptionDeliveryOptionResultUnionCasesBuilder(IQuery<SubscriptionDeliveryOptionResult> query) : base(query)
        {
        }

        public SubscriptionDeliveryOptionResultUnionCasesBuilder OnSubscriptionDeliveryOptionResultFailure(Action<SubscriptionDeliveryOptionResultFailureQueryBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryOptionResultFailure>("... on SubscriptionDeliveryOptionResultFailure");
            var queryBuilder = new SubscriptionDeliveryOptionResultFailureQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionDeliveryOptionResultUnionCasesBuilder OnSubscriptionDeliveryOptionResultSuccess(Action<SubscriptionDeliveryOptionResultSuccessQueryBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryOptionResultSuccess>("... on SubscriptionDeliveryOptionResultSuccess");
            var queryBuilder = new SubscriptionDeliveryOptionResultSuccessQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}