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
    public sealed class FulfillmentEventQueryBuilder : FieldsQueryBuilderBase<FulfillmentEvent, FulfillmentEventQueryBuilder>
    {
        protected override FulfillmentEventQueryBuilder Self => this;

        public FulfillmentEventQueryBuilder() : this("fulfillmentEvent")
        {
        }

        public FulfillmentEventQueryBuilder(string name) : base(new Query<FulfillmentEvent>(name))
        {
        }

        public FulfillmentEventQueryBuilder(IQuery<FulfillmentEvent> query) : base(query)
        {
        }

        public FulfillmentEventQueryBuilder Address1()
        {
            base.InnerQuery.AddField("address1");
            return this;
        }

        public FulfillmentEventQueryBuilder City()
        {
            base.InnerQuery.AddField("city");
            return this;
        }

        public FulfillmentEventQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        public FulfillmentEventQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public FulfillmentEventQueryBuilder EstimatedDeliveryAt()
        {
            base.InnerQuery.AddField("estimatedDeliveryAt");
            return this;
        }

        public FulfillmentEventQueryBuilder HappenedAt()
        {
            base.InnerQuery.AddField("happenedAt");
            return this;
        }

        public FulfillmentEventQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FulfillmentEventQueryBuilder Latitude()
        {
            base.InnerQuery.AddField("latitude");
            return this;
        }

        public FulfillmentEventQueryBuilder Longitude()
        {
            base.InnerQuery.AddField("longitude");
            return this;
        }

        public FulfillmentEventQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }

        public FulfillmentEventQueryBuilder Province()
        {
            base.InnerQuery.AddField("province");
            return this;
        }

        public FulfillmentEventQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public FulfillmentEventQueryBuilder Zip()
        {
            base.InnerQuery.AddField("zip");
            return this;
        }
    }
}