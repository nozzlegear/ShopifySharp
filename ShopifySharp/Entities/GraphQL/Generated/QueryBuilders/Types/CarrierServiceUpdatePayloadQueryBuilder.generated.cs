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
    public sealed class CarrierServiceUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<CarrierServiceUpdatePayload, CarrierServiceUpdatePayloadQueryBuilder>
    {
        protected override CarrierServiceUpdatePayloadQueryBuilder Self => this;

        public CarrierServiceUpdatePayloadQueryBuilder() : this("carrierServiceUpdatePayload")
        {
        }

        public CarrierServiceUpdatePayloadQueryBuilder(string name) : base(new Query<CarrierServiceUpdatePayload>(name))
        {
        }

        public CarrierServiceUpdatePayloadQueryBuilder(IQuery<CarrierServiceUpdatePayload> query) : base(query)
        {
        }

        public CarrierServiceUpdatePayloadQueryBuilder CarrierService(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder> build)
        {
            var query = new Query<DeliveryCarrierService>("carrierService");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryCarrierServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCarrierService>(query);
            return this;
        }

        public CarrierServiceUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CarrierServiceUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<CarrierServiceUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CarrierServiceUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CarrierServiceUpdateUserError>(query);
            return this;
        }
    }
}