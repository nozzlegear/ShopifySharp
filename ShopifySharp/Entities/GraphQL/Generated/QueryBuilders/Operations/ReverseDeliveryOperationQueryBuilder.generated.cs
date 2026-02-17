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
    public sealed class ReverseDeliveryOperationQueryBuilder : FieldsQueryBuilderBase<ReverseDelivery, ReverseDeliveryOperationQueryBuilder>, IGraphOperationQueryBuilder<ReverseDelivery>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ReverseDeliveryArgumentsBuilder Arguments { get; }
        protected override ReverseDeliveryOperationQueryBuilder Self => this;

        public ReverseDeliveryOperationQueryBuilder() : this("reverseDelivery")
        {
        }

        public ReverseDeliveryOperationQueryBuilder(string name) : base(new Query<ReverseDelivery>(name))
        {
            Arguments = new ReverseDeliveryArgumentsBuilder(base.InnerQuery);
        }

        public ReverseDeliveryOperationQueryBuilder(IQuery<ReverseDelivery> query) : base(query)
        {
            Arguments = new ReverseDeliveryArgumentsBuilder(base.InnerQuery);
        }

        public ReverseDeliveryOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReverseDeliveryOperationQueryBuilder ReverseDeliveryLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryLineItemConnection>("reverseDeliveryLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDeliveryLineItemConnection>(query);
            return this;
        }

        public ReverseDeliveryOperationQueryBuilder ReverseFulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrder>("reverseFulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrder>(query);
            return this;
        }

        public ReverseDeliveryOperationQueryBuilder Deliverable(Action<ReverseDeliveryDeliverableUnionCasesBuilder> build)
        {
            var query = new Query<ReverseDeliveryDeliverable>("deliverable");
            var unionBuilder = new ReverseDeliveryDeliverableUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}