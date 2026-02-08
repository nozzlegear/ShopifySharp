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
    public sealed class ReverseFulfillmentOrderOperationQueryBuilder : FieldsQueryBuilderBase<ReverseFulfillmentOrder, ReverseFulfillmentOrderOperationQueryBuilder>, IGraphOperationQueryBuilder<ReverseFulfillmentOrder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ReverseFulfillmentOrderArgumentsBuilder Arguments { get; }
        protected override ReverseFulfillmentOrderOperationQueryBuilder Self => this;

        public ReverseFulfillmentOrderOperationQueryBuilder() : this("reverseFulfillmentOrder")
        {
        }

        public ReverseFulfillmentOrderOperationQueryBuilder(string name) : base(new Query<ReverseFulfillmentOrder>(name))
        {
            Arguments = new ReverseFulfillmentOrderArgumentsBuilder(base.InnerQuery);
        }

        public ReverseFulfillmentOrderOperationQueryBuilder(IQuery<ReverseFulfillmentOrder> query) : base(query)
        {
            Arguments = new ReverseFulfillmentOrderArgumentsBuilder(base.InnerQuery);
        }

        public ReverseFulfillmentOrderOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReverseFulfillmentOrderOperationQueryBuilder LineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderLineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderLineItemConnection>(query);
            return this;
        }

        public ReverseFulfillmentOrderOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public ReverseFulfillmentOrderOperationQueryBuilder ReverseDeliveries(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryConnectionQueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryConnection>("reverseDeliveries");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseDeliveryConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDeliveryConnection>(query);
            return this;
        }

        public ReverseFulfillmentOrderOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public ReverseFulfillmentOrderOperationQueryBuilder ThirdPartyConfirmation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderThirdPartyConfirmation>("thirdPartyConfirmation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderThirdPartyConfirmation>(query);
            return this;
        }
    }
}