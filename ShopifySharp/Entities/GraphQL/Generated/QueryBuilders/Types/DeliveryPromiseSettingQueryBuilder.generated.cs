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
    public sealed class DeliveryPromiseSettingQueryBuilder : FieldsQueryBuilderBase<DeliveryPromiseSetting, DeliveryPromiseSettingQueryBuilder>
    {
        protected override DeliveryPromiseSettingQueryBuilder Self => this;

        public DeliveryPromiseSettingQueryBuilder() : this("deliveryPromiseSetting")
        {
        }

        public DeliveryPromiseSettingQueryBuilder(string name) : base(new Query<DeliveryPromiseSetting>(name))
        {
        }

        public DeliveryPromiseSettingQueryBuilder(IQuery<DeliveryPromiseSetting> query) : base(query)
        {
        }

        public DeliveryPromiseSettingQueryBuilder DeliveryDatesEnabled()
        {
            base.InnerQuery.AddField("deliveryDatesEnabled");
            return this;
        }

        public DeliveryPromiseSettingQueryBuilder ProcessingTime()
        {
            base.InnerQuery.AddField("processingTime");
            return this;
        }
    }
}