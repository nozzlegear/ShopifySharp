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
    public sealed class SubscriptionShippingOptionResultQueryBuilder : FieldsQueryBuilderBase<SubscriptionShippingOptionResult, SubscriptionShippingOptionResultQueryBuilder>, IHasArguments<SubscriptionShippingOptionResultArgumentsBuilder>
    {
        public SubscriptionShippingOptionResultArgumentsBuilder Arguments { get; }
        protected override SubscriptionShippingOptionResultQueryBuilder Self => this;

        public SubscriptionShippingOptionResultQueryBuilder() : this("subscriptionShippingOptionResult")
        {
        }

        public SubscriptionShippingOptionResultQueryBuilder(string name) : base(new Query<SubscriptionShippingOptionResult>(name))
        {
            Arguments = new SubscriptionShippingOptionResultArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionShippingOptionResultQueryBuilder(IQuery<SubscriptionShippingOptionResult> query) : base(query)
        {
            Arguments = new SubscriptionShippingOptionResultArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionShippingOptionResultQueryBuilder SetArguments(Action<SubscriptionShippingOptionResultArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
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