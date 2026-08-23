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
    public sealed class DeliveryCarrierCalculatedRateGroupQueryBuilder : FieldsQueryBuilderBase<DeliveryCarrierCalculatedRateGroup, DeliveryCarrierCalculatedRateGroupQueryBuilder>
    {
        protected override DeliveryCarrierCalculatedRateGroupQueryBuilder Self => this;

        public DeliveryCarrierCalculatedRateGroupQueryBuilder() : this("deliveryCarrierCalculatedRateGroup")
        {
        }

        public DeliveryCarrierCalculatedRateGroupQueryBuilder(string name) : base(new Query<DeliveryCarrierCalculatedRateGroup>(name))
        {
        }

        public DeliveryCarrierCalculatedRateGroupQueryBuilder(IQuery<DeliveryCarrierCalculatedRateGroup> query) : base(query)
        {
        }

        public DeliveryCarrierCalculatedRateGroupQueryBuilder AbsoluteAdjustment(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("absoluteAdjustment");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public DeliveryCarrierCalculatedRateGroupQueryBuilder AutoIncludeNewServices()
        {
            base.InnerQuery.AddField("autoIncludeNewServices");
            return this;
        }

        public DeliveryCarrierCalculatedRateGroupQueryBuilder CarrierService(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("carrierService");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierService>(query);
            return this;
        }

        public DeliveryCarrierCalculatedRateGroupQueryBuilder Conditions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryRateGroupConditionsQueryBuilder> build)
        {
            var query = new Query<DeliveryRateGroupConditions>("conditions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryRateGroupConditionsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryRateGroupConditions>(query);
            return this;
        }

        public DeliveryCarrierCalculatedRateGroupQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryCarrierCalculatedRateGroupQueryBuilder PercentageAdjustment()
        {
            base.InnerQuery.AddField("percentageAdjustment");
            return this;
        }

        public DeliveryCarrierCalculatedRateGroupQueryBuilder ServiceConfiguration(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierCalculatedRateGroupServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierCalculatedRateGroupService>("serviceConfiguration");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryCarrierCalculatedRateGroupServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierCalculatedRateGroupService>(query);
            return this;
        }
    }
}