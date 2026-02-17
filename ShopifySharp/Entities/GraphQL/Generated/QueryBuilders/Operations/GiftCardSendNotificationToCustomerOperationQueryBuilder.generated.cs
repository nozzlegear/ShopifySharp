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
    public sealed class GiftCardSendNotificationToCustomerOperationQueryBuilder : FieldsQueryBuilderBase<GiftCardSendNotificationToCustomerPayload, GiftCardSendNotificationToCustomerOperationQueryBuilder>, IGraphOperationQueryBuilder<GiftCardSendNotificationToCustomerPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public GiftCardSendNotificationToCustomerArgumentsBuilder Arguments { get; }
        protected override GiftCardSendNotificationToCustomerOperationQueryBuilder Self => this;

        public GiftCardSendNotificationToCustomerOperationQueryBuilder() : this("giftCardSendNotificationToCustomer")
        {
        }

        public GiftCardSendNotificationToCustomerOperationQueryBuilder(string name) : base(new Query<GiftCardSendNotificationToCustomerPayload>(name))
        {
            Arguments = new GiftCardSendNotificationToCustomerArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardSendNotificationToCustomerOperationQueryBuilder(IQuery<GiftCardSendNotificationToCustomerPayload> query) : base(query)
        {
            Arguments = new GiftCardSendNotificationToCustomerArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardSendNotificationToCustomerOperationQueryBuilder GiftCard(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("giftCard");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public GiftCardSendNotificationToCustomerOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardSendNotificationToCustomerUserErrorQueryBuilder> build)
        {
            var query = new Query<GiftCardSendNotificationToCustomerUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardSendNotificationToCustomerUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardSendNotificationToCustomerUserError>(query);
            return this;
        }
    }
}