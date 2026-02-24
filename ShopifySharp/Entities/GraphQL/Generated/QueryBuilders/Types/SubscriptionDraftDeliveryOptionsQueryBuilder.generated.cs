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
    public sealed class SubscriptionDraftDeliveryOptionsQueryBuilder : FieldsQueryBuilderBase<SubscriptionDeliveryOptionResult, SubscriptionDraftDeliveryOptionsQueryBuilder>, IHasArguments<SubscriptionDraftDeliveryOptionsArgumentsBuilder>
    {
        public SubscriptionDraftDeliveryOptionsArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftDeliveryOptionsQueryBuilder Self => this;

        public SubscriptionDraftDeliveryOptionsQueryBuilder(string name) : base(new Query<SubscriptionDeliveryOptionResult>(name))
        {
            Arguments = new SubscriptionDraftDeliveryOptionsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftDeliveryOptionsQueryBuilder(IQuery<SubscriptionDeliveryOptionResult> query) : base(query)
        {
            Arguments = new SubscriptionDraftDeliveryOptionsArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftDeliveryOptionsQueryBuilder SetArguments(Action<SubscriptionDraftDeliveryOptionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SubscriptionDraftDeliveryOptionsQueryBuilder SubscriptionDeliveryOptionResult(Action<SubscriptionDeliveryOptionResultUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryOptionResult>("subscriptionDeliveryOptionResult");
            var unionBuilder = new SubscriptionDeliveryOptionResultUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}