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
    public sealed class ReverseDeliveryQueryBuilder : FieldsQueryBuilderBase<ReverseDelivery, ReverseDeliveryQueryBuilder>
    {
        protected override ReverseDeliveryQueryBuilder Self => this;

        public ReverseDeliveryQueryBuilder() : this("reverseDelivery")
        {
        }

        public ReverseDeliveryQueryBuilder(string name) : base(new Query<ReverseDelivery>(name))
        {
        }

        public ReverseDeliveryQueryBuilder(IQuery<ReverseDelivery> query) : base(query)
        {
        }

        public ReverseDeliveryQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReverseDeliveryQueryBuilder ReverseDeliveryLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryLineItemConnection>("reverseDeliveryLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDeliveryLineItemConnection>(query);
            return this;
        }

        public ReverseDeliveryQueryBuilder ReverseFulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrder>("reverseFulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrder>(query);
            return this;
        }

        public ReverseDeliveryQueryBuilder Deliverable(Action<ReverseDeliveryDeliverableUnionCasesBuilder> build)
        {
            var query = new Query<ReverseDeliveryDeliverable>("deliverable");
            var unionBuilder = new ReverseDeliveryDeliverableUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}