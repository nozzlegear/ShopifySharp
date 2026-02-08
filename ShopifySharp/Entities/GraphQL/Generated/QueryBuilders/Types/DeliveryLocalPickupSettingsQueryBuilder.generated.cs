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
    public sealed class DeliveryLocalPickupSettingsQueryBuilder : FieldsQueryBuilderBase<DeliveryLocalPickupSettings, DeliveryLocalPickupSettingsQueryBuilder>
    {
        protected override DeliveryLocalPickupSettingsQueryBuilder Self => this;

        public DeliveryLocalPickupSettingsQueryBuilder() : this("deliveryLocalPickupSettings")
        {
        }

        public DeliveryLocalPickupSettingsQueryBuilder(string name) : base(new Query<DeliveryLocalPickupSettings>(name))
        {
        }

        public DeliveryLocalPickupSettingsQueryBuilder(IQuery<DeliveryLocalPickupSettings> query) : base(query)
        {
        }

        public DeliveryLocalPickupSettingsQueryBuilder Instructions()
        {
            base.InnerQuery.AddField("instructions");
            return this;
        }

        public DeliveryLocalPickupSettingsQueryBuilder PickupTime()
        {
            base.InnerQuery.AddField("pickupTime");
            return this;
        }
    }
}