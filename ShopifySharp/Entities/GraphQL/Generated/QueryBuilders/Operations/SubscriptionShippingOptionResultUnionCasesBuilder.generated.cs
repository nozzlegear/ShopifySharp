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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class SubscriptionShippingOptionResultUnionCasesBuilder : UnionCasesBuilderBase<SubscriptionShippingOptionResult, SubscriptionShippingOptionResultUnionCasesBuilder>
    {
        protected override SubscriptionShippingOptionResultUnionCasesBuilder Self => this;

        public SubscriptionShippingOptionResultUnionCasesBuilder(string fieldName = "shippingOptions") : this(new Query<SubscriptionShippingOptionResult>(fieldName))
        {
        }

        public SubscriptionShippingOptionResultUnionCasesBuilder(IQuery<SubscriptionShippingOptionResult> query) : base(query)
        {
        }

        public SubscriptionShippingOptionResultUnionCasesBuilder OnSubscriptionShippingOptionResultFailure(Action<SubscriptionShippingOptionResultFailureQueryBuilder> build)
        {
            var query = new Query<SubscriptionShippingOptionResultFailure>("... on SubscriptionShippingOptionResultFailure");
            var queryBuilder = new SubscriptionShippingOptionResultFailureQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionShippingOptionResultUnionCasesBuilder OnSubscriptionShippingOptionResultSuccess(Action<SubscriptionShippingOptionResultSuccessQueryBuilder> build)
        {
            var query = new Query<SubscriptionShippingOptionResultSuccess>("... on SubscriptionShippingOptionResultSuccess");
            var queryBuilder = new SubscriptionShippingOptionResultSuccessQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}