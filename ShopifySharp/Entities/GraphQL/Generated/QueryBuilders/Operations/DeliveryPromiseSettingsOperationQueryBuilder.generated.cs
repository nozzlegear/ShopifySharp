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