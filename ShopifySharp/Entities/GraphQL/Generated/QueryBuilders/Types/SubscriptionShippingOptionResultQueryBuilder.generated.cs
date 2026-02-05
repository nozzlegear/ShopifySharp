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
    public sealed class SubscriptionShippingOptionResultQueryBuilder : FieldsQueryBuilderBase<SubscriptionShippingOptionResult, SubscriptionShippingOptionResultQueryBuilder>
    {
        protected override SubscriptionShippingOptionResultQueryBuilder Self => this;

        public SubscriptionShippingOptionResultQueryBuilder() : this("subscriptionShippingOptionResult")
        {
        }

        public SubscriptionShippingOptionResultQueryBuilder(string name) : base(new Query<SubscriptionShippingOptionResult>(name))
        {
        }

        public SubscriptionShippingOptionResultQueryBuilder(IQuery<SubscriptionShippingOptionResult> query) : base(query)
        {
        }

        public SubscriptionShippingOptionResultQueryBuilder SubscriptionShippingOptionResult(Action<SubscriptionShippingOptionResultUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionShippingOptionResult>("subscriptionShippingOptionResult");
            var unionBuilder = new SubscriptionShippingOptionResultUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}