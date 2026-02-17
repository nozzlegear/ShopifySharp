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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class AppSubscriptionLineItemUpdateOperationQueryBuilder : FieldsQueryBuilderBase<AppSubscriptionLineItemUpdatePayload, AppSubscriptionLineItemUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<AppSubscriptionLineItemUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public AppSubscriptionLineItemUpdateArgumentsBuilder Arguments { get; }
        protected override AppSubscriptionLineItemUpdateOperationQueryBuilder Self => this;

        public AppSubscriptionLineItemUpdateOperationQueryBuilder() : this("appSubscriptionLineItemUpdate")
        {
        }

        public AppSubscriptionLineItemUpdateOperationQueryBuilder(string name) : base(new Query<AppSubscriptionLineItemUpdatePayload>(name))
        {
            Arguments = new AppSubscriptionLineItemUpdateArgumentsBuilder(base.InnerQuery);
        }

        public AppSubscriptionLineItemUpdateOperationQueryBuilder(IQuery<AppSubscriptionLineItemUpdatePayload> query) : base(query)
        {
            Arguments = new AppSubscriptionLineItemUpdateArgumentsBuilder(base.InnerQuery);
        }

        public AppSubscriptionLineItemUpdateOperationQueryBuilder AppSubscription(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionQueryBuilder> build)
        {
            var query = new Query<AppSubscription>("appSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscription>(query);
            return this;
        }

        public AppSubscriptionLineItemUpdateOperationQueryBuilder ConfirmationUrl()
        {
            base.InnerQuery.AddField("confirmationUrl");
            return this;
        }

        public AppSubscriptionLineItemUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}