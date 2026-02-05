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
    public sealed class DeliveryCarrierServiceQueryBuilder : FieldsQueryBuilderBase<DeliveryCarrierService, DeliveryCarrierServiceQueryBuilder>
    {
        protected override DeliveryCarrierServiceQueryBuilder Self => this;

        public DeliveryCarrierServiceQueryBuilder() : this("deliveryCarrierService")
        {
        }

        public DeliveryCarrierServiceQueryBuilder(string name) : base(new Query<DeliveryCarrierService>(name))
        {
        }

        public DeliveryCarrierServiceQueryBuilder(IQuery<DeliveryCarrierService> query) : base(query)
        {
        }

        public DeliveryCarrierServiceQueryBuilder Active()
        {
            base.InnerQuery.AddField("active");
            return this;
        }

        public DeliveryCarrierServiceQueryBuilder AvailableServicesForCountries(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryAvailableServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryAvailableService>("availableServicesForCountries");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryAvailableServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryAvailableService>(query);
            return this;
        }

        public DeliveryCarrierServiceQueryBuilder CallbackUrl()
        {
            base.InnerQuery.AddField("callbackUrl");
            return this;
        }

        public DeliveryCarrierServiceQueryBuilder FormattedName()
        {
            base.InnerQuery.AddField("formattedName");
            return this;
        }

        public DeliveryCarrierServiceQueryBuilder Icon(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("icon");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public DeliveryCarrierServiceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryCarrierServiceQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public DeliveryCarrierServiceQueryBuilder SupportsServiceDiscovery()
        {
            base.InnerQuery.AddField("supportsServiceDiscovery");
            return this;
        }
    }
}