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
    public sealed class DeliveryLocationLocalPickupSettingsErrorQueryBuilder : FieldsQueryBuilderBase<DeliveryLocationLocalPickupSettingsError, DeliveryLocationLocalPickupSettingsErrorQueryBuilder>
    {
        protected override DeliveryLocationLocalPickupSettingsErrorQueryBuilder Self => this;

        public DeliveryLocationLocalPickupSettingsErrorQueryBuilder() : this("deliveryLocationLocalPickupSettingsError")
        {
        }

        public DeliveryLocationLocalPickupSettingsErrorQueryBuilder(string name) : base(new Query<DeliveryLocationLocalPickupSettingsError>(name))
        {
        }

        public DeliveryLocationLocalPickupSettingsErrorQueryBuilder(IQuery<DeliveryLocationLocalPickupSettingsError> query) : base(query)
        {
        }

        public DeliveryLocationLocalPickupSettingsErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public DeliveryLocationLocalPickupSettingsErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DeliveryLocationLocalPickupSettingsErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}