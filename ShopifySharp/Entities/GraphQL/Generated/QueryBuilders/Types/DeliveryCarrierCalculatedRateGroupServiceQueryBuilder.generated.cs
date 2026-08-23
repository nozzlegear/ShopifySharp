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
    public sealed class DeliveryCarrierCalculatedRateGroupServiceQueryBuilder : FieldsQueryBuilderBase<DeliveryCarrierCalculatedRateGroupService, DeliveryCarrierCalculatedRateGroupServiceQueryBuilder>
    {
        protected override DeliveryCarrierCalculatedRateGroupServiceQueryBuilder Self => this;

        public DeliveryCarrierCalculatedRateGroupServiceQueryBuilder() : this("deliveryCarrierCalculatedRateGroupService")
        {
        }

        public DeliveryCarrierCalculatedRateGroupServiceQueryBuilder(string name) : base(new Query<DeliveryCarrierCalculatedRateGroupService>(name))
        {
        }

        public DeliveryCarrierCalculatedRateGroupServiceQueryBuilder(IQuery<DeliveryCarrierCalculatedRateGroupService> query) : base(query)
        {
        }

        public DeliveryCarrierCalculatedRateGroupServiceQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public DeliveryCarrierCalculatedRateGroupServiceQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}