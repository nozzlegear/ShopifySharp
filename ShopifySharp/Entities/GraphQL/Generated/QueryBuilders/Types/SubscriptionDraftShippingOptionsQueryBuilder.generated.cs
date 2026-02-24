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
    public sealed class SubscriptionDraftShippingOptionsQueryBuilder : FieldsQueryBuilderBase<SubscriptionShippingOptionResult, SubscriptionDraftShippingOptionsQueryBuilder>, IHasArguments<SubscriptionDraftShippingOptionsArgumentsBuilder>
    {
        public SubscriptionDraftShippingOptionsArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftShippingOptionsQueryBuilder Self => this;

        public SubscriptionDraftShippingOptionsQueryBuilder(string name) : base(new Query<SubscriptionShippingOptionResult>(name))
        {
            Arguments = new SubscriptionDraftShippingOptionsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftShippingOptionsQueryBuilder(IQuery<SubscriptionShippingOptionResult> query) : base(query)
        {
            Arguments = new SubscriptionDraftShippingOptionsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftShippingOptionsQueryBuilder SetArguments(Action<SubscriptionDraftShippingOptionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SubscriptionDraftShippingOptionsQueryBuilder SubscriptionShippingOptionResult(Action<SubscriptionShippingOptionResultUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionShippingOptionResult>("subscriptionShippingOptionResult");
            var unionBuilder = new SubscriptionShippingOptionResultUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}