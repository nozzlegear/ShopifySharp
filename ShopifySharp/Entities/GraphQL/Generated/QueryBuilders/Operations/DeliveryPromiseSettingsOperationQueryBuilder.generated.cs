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
    public sealed class DeliveryPromiseSettingsOperationQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseSetting, DeliveryPromiseSettingsOperationQueryBuilder>, IGraphOperationQueryBuilder<DeliveryPromiseSetting>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override DeliveryPromiseSettingsOperationQueryBuilder Self => this;

        public DeliveryPromiseSettingsOperationQueryBuilder() : this("deliveryPromiseSettings")
        {
        }

        public DeliveryPromiseSettingsOperationQueryBuilder(string name) : base(new Query<DeliveryPromiseSetting>(name))
        {
        }

        public DeliveryPromiseSettingsOperationQueryBuilder(IQuery<DeliveryPromiseSetting> query) : base(query)
        {
        }

        public DeliveryPromiseSettingsOperationQueryBuilder DeliveryDatesEnabled()
        {
            base.InnerQuery.AddField("deliveryDatesEnabled");
            return this;
        }

        public DeliveryPromiseSettingsOperationQueryBuilder ProcessingTime()
        {
            base.InnerQuery.AddField("processingTime");
            return this;
        }
    }
}